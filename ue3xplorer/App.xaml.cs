using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace ue3explorer;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
  public App()
  {
    InitializeComponent();
  }

  [DllImport("dwmapi.dll")]
  private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

  private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

  public static void UseImmersiveDarkMode(Window window)
  {
    IntPtr handle = new WindowInteropHelper(window).Handle;
    
    var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
    int useImmersiveDarkMode = 1;
    DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int));
  }
}