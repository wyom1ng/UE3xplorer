using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using Ookii.Dialogs.Wpf;
using ue3;

namespace ue3explorer;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class Startup : Window
{
  public Startup()
  {
    InitializeComponent();
  }

  protected override void OnSourceInitialized(EventArgs e)
  {
    base.OnSourceInitialized(e);
    App.UseImmersiveDarkMode(this);
  }

  private void PathBrowse_OnClick(object sender, RoutedEventArgs e)
  {
    var dialog = new VistaFolderBrowserDialog
    {
      Description = "decompressed .upk directory",
      UseDescriptionForTitle = true
    };
    if (Directory.Exists("E:\\ksf2_decompressed")) dialog.SelectedPath = "E:\\ksf2_decompressed\\";

    if ((bool)dialog.ShowDialog(this))
    {
      Path.Text = dialog.SelectedPath;
    }
  }

  private void OkButton_OnClick(object sender, RoutedEventArgs e)
  {
    if (Directory.Exists(Path.Text))
    {
      ULinkerLoad.InitFileCache(Path.Text, Locale.Text);

      PackageList list = new PackageList();
      list.Show();

      Close();
    }
  }
}