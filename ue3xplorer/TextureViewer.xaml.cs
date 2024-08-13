using System.Runtime.InteropServices;
using SharpDX;
using SharpDX.D3DCompiler;
using SharpDX.Direct3D;
using SharpDX.DXGI;
using System.Windows;
using System.Windows.Media;
using D3D11 = SharpDX.Direct3D11;
using SharpDX.Mathematics.Interop;
using ue3;
using Vector = System.Windows.Vector;

namespace ue3explorer;

public partial class TextureViewer : Window
{
  UTexture2D underlying;
  List<D3D11.Texture2D> textures = new();
  D3D11.SamplerState sampler;

  D3D11.Device device;
  D3D11.DeviceContext deviceContext;
  D3D11.RenderTargetView renderTargetView;
  TimeSpan lastRender = TimeSpan.Zero;

  public TextureViewer(UTexture2D Underlying)
  {
    InitializeComponent();

    Underlying.Linker.FullyLoadObject(Underlying);
    underlying = Underlying;
    if (underlying.Mips.Count > 0)
    {
      Title = "UE3xplorer - " + underlying.Name.Resolved;
      ImageGrid.Width = underlying.Mips[0].SizeX;
      ImageGrid.Height = underlying.Mips[0].SizeY;
    }

    InitializeDevice();

    if (ImageGrid.IsLoaded) Grid_Loaded(ImageGrid, null);
    else ImageGrid.Loaded += Grid_Loaded;
    ImageGrid.SizeChanged += Grid_SizeChanged;

    Closing += TextureViewer_Closing;
  }

  private void Grid_Loaded(object sender, RoutedEventArgs e)
  {
    InteropImage.WindowOwner = (new System.Windows.Interop.WindowInteropHelper(this)).Handle;
    InteropImage.IsFrontBufferAvailableChanged += InteropImage_IsFrontBufferAvailableChanged;
    InteropImage.OnRender += OnRender;

    CompositionTarget.Rendering += CompositionTarget_Rendering;
  }

  private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
  {
    Size size = WpfSizeToPixels(ImageGrid);

    InteropImage.SetPixelSize((int)size.Width, (int)size.Height);
  }

  void InitializeSharedBackBuffer(IntPtr resourcePtr)
  {
    Resource resource = CppObject.FromPointer<Resource>(resourcePtr).QueryInterface<Resource>();
    D3D11.Texture2D sharedBackbuffer = device.OpenSharedResource<D3D11.Texture2D>(resource.SharedHandle);
    resource.Dispose();

    D3D11.RenderTargetViewDescription desc = new();
    desc.Format = Format.B8G8R8A8_UNorm;
    desc.Dimension = D3D11.RenderTargetViewDimension.Texture2D;
    desc.Texture2D.MipSlice = 0;

    renderTargetView = new(device, sharedBackbuffer, desc);
    deviceContext.OutputMerger.SetRenderTargets(renderTargetView);

    sharedBackbuffer.Dispose();

    Size size = WpfSizeToPixels(ImageGrid);

    D3D11.RasterizerStateDescription description = D3D11.RasterizerStateDescription.Default();
    description.CullMode = D3D11.CullMode.None;
    deviceContext.Rasterizer.State = new D3D11.RasterizerState(device, description);
    deviceContext.Rasterizer.SetViewport(new SharpDX.Viewport(0, 0, (int)size.Width, (int)size.Height, 0.0f, 1.0f));
  }

  void CompositionTarget_Rendering(object sender, EventArgs e)
  {
    RenderingEventArgs args = (RenderingEventArgs)e;

    // It's possible for Rendering to call back twice in the same frame so only render when we haven't already rendered in this frame.
    if (lastRender != args.RenderingTime)
    {
      InteropImage.RequestRender();
      lastRender = args.RenderingTime;
    }
  }


  private void InteropImage_IsFrontBufferAvailableChanged(object sender, DependencyPropertyChangedEventArgs e)
  {
    if ((bool)e.NewValue == false)
    {
      // force recreation of lost frontbuffer
      Size size = WpfSizeToPixels(ImageGrid);

      InteropImage.SetPixelSize((int)size.Width + 1, (int)size.Height + 1);
      InteropImage.SetPixelSize((int)size.Width, (int)size.Height);

      InteropImage.RequestRender();
    }
  }

  [StructLayout(LayoutKind.Sequential)]
  private struct Vertex
  {
    public Vector4 Position;
    public Vector4 UV;
  }

  void InitializeDevice()
  {
    // Create Direct3D 11 Device without SwapChain
    device = new D3D11.Device(DriverType.Hardware, D3D11.DeviceCreationFlags.BgraSupport);

    deviceContext = device.ImmediateContext;

    var vertexShaderByteCode = ShaderBytecode.CompileFromFile("Shaders/TextureViewer.hlsl", "VSMain", "vs_4_0");
    var vertexShader = new D3D11.VertexShader(device, vertexShaderByteCode);

    var pixelShaderByteCode = ShaderBytecode.CompileFromFile("Shaders/TextureViewer.hlsl", "PSMain", "ps_4_0");
    var pixelShader = new D3D11.PixelShader(device, pixelShaderByteCode);

    // Layout from VertexShader input signature
    var layout = new D3D11.InputLayout(
      device,
      ShaderSignature.GetInputSignature(vertexShaderByteCode),
      [
        new D3D11.InputElement("POSITION", 0, Format.R32G32B32A32_Float, 0, 0),
        new D3D11.InputElement("TEXCOORD", 0, Format.R32G32B32A32_Float, 16, 0)
      ]);

    var vertices = D3D11.Buffer.Create(device, D3D11.BindFlags.VertexBuffer, [
      new Vertex { Position = new Vector4(-1.0f, -1.0f, 0.5f, 1.0f), UV = new Vector4(0.0f, 1.0f, 0.0f, 0.0f) },
      new Vertex { Position = new Vector4(+1.0f, -1.0f, 0.5f, 1.0f), UV = new Vector4(1.0f, 1.0f, 0.0f, 0.0f) },
      new Vertex { Position = new Vector4(-1.0f, +1.0f, 0.5f, 1.0f), UV = new Vector4(0.0f, 0.0f, 0.0f, 0.0f) },
      new Vertex { Position = new Vector4(+1.0f, +1.0f, 0.5f, 1.0f), UV = new Vector4(1.0f, 0.0f, 0.0f, 0.0f) },
    ]);

    deviceContext.InputAssembler.InputLayout = layout;
    deviceContext.InputAssembler.PrimitiveTopology = PrimitiveTopology.TriangleStrip;
    deviceContext.InputAssembler.SetVertexBuffers(0, new D3D11.VertexBufferBinding(vertices, 32, 0));

    deviceContext.VertexShader.Set(vertexShader);
    deviceContext.PixelShader.Set(pixelShader);

    foreach (UTexture2D.FTexture2DMipMap Mip in underlying.Mips)
    {
      byte[] data = Mip.Data.BulkData;
      using (var buffer = SharpDX.DataStream.Create(data, true, true))
      {
        var FormatInfo = Formats[(int)underlying.Format];
        int BlockCountX = (Mip.SizeX + FormatInfo.BlockSizeX - 1) / FormatInfo.BlockSizeX;
        int RowPitch = BlockCountX * FormatInfo.BlockBytes;

        D3D11.Texture2D texture = new D3D11.Texture2D(device,
          new D3D11.Texture2DDescription
          {
            Width = Mip.SizeX,
            Height = Mip.SizeY,
            ArraySize = 1,
            BindFlags = SharpDX.Direct3D11.BindFlags.ShaderResource,
            Usage = SharpDX.Direct3D11.ResourceUsage.Immutable,
            CpuAccessFlags = SharpDX.Direct3D11.CpuAccessFlags.None,
            Format = FormatInfo.D3D11Format,
            MipLevels = 1,
            OptionFlags = SharpDX.Direct3D11.ResourceOptionFlags.None,
            SampleDescription = new SharpDX.DXGI.SampleDescription(1, 0),
          }, new SharpDX.DataRectangle(buffer.DataPointer, RowPitch));

        textures.Add(texture);
      }
    }

    sampler = new
    (device, new D3D11.SamplerStateDescription()
    {
      Filter = D3D11.Filter.Anisotropic,
      AddressU = D3D11.TextureAddressMode.Border,
      AddressV = D3D11.TextureAddressMode.Border,
      AddressW = D3D11.TextureAddressMode.Border,
      MinimumLod = float.MinValue,
      MaximumLod = float.MaxValue,
      MipLodBias = 0.0f,
      MaximumAnisotropy = 16,
      ComparisonFunction = D3D11.Comparison.Never,
      BorderColor = new RawColor4(1, 1, 1, 1)
    });
  }

  void OnRender(IntPtr resourcePtr, bool isNewSurface)
  {
    if (isNewSurface)
    {
      // a new surface has been created (e.g. after a resize)
      InitializeSharedBackBuffer(resourcePtr);
    }

    deviceContext.ClearRenderTargetView(renderTargetView, new RawColor4(0, 0, 0, 1));
    if (textures.Count > 0)
      deviceContext.PixelShader.SetShaderResource(0, new D3D11.ShaderResourceView(device, textures[0]));
    deviceContext.PixelShader.SetSampler(0, sampler);
    deviceContext.Draw(4, 0);
    deviceContext.Flush();
  }

  private void TextureViewer_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
    CompositionTarget.Rendering -= CompositionTarget_Rendering;
    deviceContext.Dispose();
    device.Dispose();
  }

  private static Size WpfSizeToPixels(FrameworkElement element)
  {
    var source = PresentationSource.FromVisual(element);
    System.Windows.Media.Matrix transformToDevice = source.CompositionTarget.TransformToDevice;

    return (Size)transformToDevice.Transform(new Vector(element.ActualWidth, element.ActualHeight));
  }

  private struct PixelFormat
  {
    public int BlockSizeX;
    public int BlockSizeY;
    public int BlockSizeZ;
    public int BlockBytes;
    public int ComponentCount;
    public Format D3D11Format;
  }

  private PixelFormat[] Formats =
  [
    // @formatter:off
  new PixelFormat {    BlockSizeX = 0, BlockSizeY=  0,BlockSizeZ = 0,    BlockBytes =  0,    ComponentCount=     0,    D3D11Format=        Format.Unknown,               /* PF_Unknown              */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes = 16,    ComponentCount=     4,    D3D11Format=        Format.R32G32B32A32_Float,    /* PF_A32B32G32R32F        */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     4,    D3D11Format=        Format.R8G8B8A8_UNorm,        /* PF_A8R8G8B8             */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  1,    ComponentCount=     1,    D3D11Format=        Format.R8_UNorm,              /* PF_G8                   */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  2,    ComponentCount=     1,    D3D11Format=        Format.Unknown,               /* PF_G16                  */  },
  new PixelFormat {    BlockSizeX = 4, BlockSizeY=  4,BlockSizeZ = 1,    BlockBytes =  8,    ComponentCount=     3,    D3D11Format=        Format.BC1_UNorm,             /* PF_DXT1                 */  },
  new PixelFormat {    BlockSizeX = 4, BlockSizeY=  4,BlockSizeZ = 1,    BlockBytes = 16,    ComponentCount=     4,    D3D11Format=        Format.BC2_UNorm,             /* PF_DXT3                 */  },
  new PixelFormat {    BlockSizeX = 4, BlockSizeY=  4,BlockSizeZ = 1,    BlockBytes = 16,    ComponentCount=     4,    D3D11Format=        Format.BC3_UNorm,             /* PF_DXT5                 */  },
  new PixelFormat {    BlockSizeX = 2, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     4,    D3D11Format=        Format.Unknown,               /* PF_UYVY                 */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  8,    ComponentCount=     3,    D3D11Format=        Format.R16G16B16A16_Float,    /* PF_FloatRGB             */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  8,    ComponentCount=     4,    D3D11Format=        Format.R16G16B16A16_Float,    /* PF_FloatRGBA            */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     1,    D3D11Format=        Format.R24G8_Typeless,        /* PF_DepthStencil         */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     1,    D3D11Format=        Format.R24G8_Typeless,        /* PF_ShadowDepth          */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     1,    D3D11Format=        Format.R24_UNorm_X8_Typeless, /* PF_FilteredShadowDepth  */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     1,    D3D11Format=        Format.R32_Float,             /* PF_R32F                 */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     2,    D3D11Format=        Format.R16G16_UNorm,          /* PF_G16R16               */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     2,    D3D11Format=        Format.R16G16_Float,          /* PF_G16R16F              */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     2,    D3D11Format=        Format.R16G16_Float,          /* PF_G16R16F_FILTER       */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  8,    ComponentCount=     2,    D3D11Format=        Format.R32G32_Float,          /* PF_G32R32F              */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     4,    D3D11Format=        Format.R10G10B10A2_UNorm,     /* PF_A2B10G10R10          */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  8,    ComponentCount=     4,    D3D11Format=        Format.R16G16B16A16_UNorm,    /* PF_A16B16G16R16         */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  4,    ComponentCount=     1,    D3D11Format=        Format.Unknown,               /* PF_D24                  */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  2,    ComponentCount=     1,    D3D11Format=        Format.R16_Float,             /* PF_R16F                 */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  2,    ComponentCount=     1,    D3D11Format=        Format.R16_Float,             /* PF_R16F_FILTER          */  },
  new PixelFormat {    BlockSizeX = 4, BlockSizeY=  4,BlockSizeZ = 1,    BlockBytes = 16,    ComponentCount=     2,    D3D11Format=        Format.BC5_UNorm,             /* PF_BC5                  */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  2,    ComponentCount=     2,    D3D11Format=        Format.R8G8_SNorm,            /* PF_V8U8                 */  },
  new PixelFormat {    BlockSizeX = 1, BlockSizeY=  1,BlockSizeZ = 1,    BlockBytes =  1,    ComponentCount=     1,    D3D11Format=        Format.R1_UNorm,              /* PF_A1                   */  },
    // @formatter:on
  ];
}