using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using ue3;

namespace ue3explorer;

public partial class Texture : Window
{
  private UTexture2D texture;

  public Texture()
  {
    InitializeComponent();
    
    CompositionTarget.Rendering += CompositionTarget_Rendering;
  }
  
  void CompositionTarget_Rendering(object? sender, EventArgs e)
  {
    RenderingEventArgs args = (RenderingEventArgs)e;
    // It's possible for Rendering to call back twice in the same frame 
    // so only render when we haven't already rendered in this frame.
    if (this._lastRender != args.RenderingTime)
    {
      InteropImage.RequestRender();
      this._lastRender = args.RenderingTime;
    }
  }
}