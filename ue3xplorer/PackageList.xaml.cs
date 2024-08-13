using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ue3;

namespace ue3explorer;

public partial class PackageList : Window
{
  class PackageView
  {
    public string Name { get; set; }
    public double FileSizeMiB { get; set; }
    public string Compression { get; set; }
    public int Imports { get; set; }
    public int Exports { get; set; }
    public string Guid { get; set; }
  }

  private TextBox filterInput;
  private ObservableCollection<PackageView> packages = new();
  private CollectionViewSource packagesSourceList;

  protected override void OnSourceInitialized(EventArgs e)
  {
    base.OnSourceInitialized(e);
    App.UseImmersiveDarkMode(this);
  }

  public PackageList()
  {
    InitializeComponent();

    Progress.Maximum = ULinkerLoad.FileCache.Count;
    PackagesDataGrid.AutoGenerateColumns = false;
    packagesSourceList = new() { Source = packages };
    PackagesDataGrid.ItemsSource = packagesSourceList.View;
    Task.Run(LoadPackages);
  }

  private void LoadPackages()
  {
    foreach (ULinkerLoad.FPackageFileSummary summary in ULinkerLoad.LoadSummaries())
    {
      PackageView view = new();

      view.Name = summary.PackageName;
      view.FileSizeMiB = summary.FileSize / (1024.0 * 1024.0);
      view.Compression = FormatCompression(summary.CompressionFlags);
      view.Imports = summary.ImportCount;
      view.Exports = summary.ExportCount;
      view.Guid = summary.Guid.ToString();

      Application.Current.Dispatcher.Invoke(() =>
      {
        Progress.Value = PackagesDataGrid.Items.Count;
        packages.Add(view);
      });
    }


    Application.Current.Dispatcher.Invoke(() =>
    {
      Grid.Children.Remove(Progress);

      Label label = new Label();
      label.Content = "filter:";
      label.Margin = new Thickness(0, 4, 8, 4);
      Grid.SetRow(label, 1);
      Grid.Children.Add(label);

      filterInput = new TextBox();
      filterInput.Margin = new Thickness(4);
      filterInput.TextChanged += Filter_TextChanged;
      Grid.SetRow(filterInput, 1);
      Grid.SetColumn(filterInput, 1);
      Grid.Children.Add(filterInput);
    });
  }

  private void Filter_TextChanged(object sender, TextChangedEventArgs e)
  {
    if (filterInput.Text.Length > 0)
    {
      string query = filterInput.Text;
      packagesSourceList.View.Filter = item =>
      {
        PackageView packageView = (PackageView)item;
        if (packageView.Name.Contains(query, StringComparison.OrdinalIgnoreCase)) return true;
        return false;
      };
    }
    else
    {
      packagesSourceList.View.Filter = null;
    }
  }

  private void PackageView_Click(object sender, RoutedEventArgs e)
  {
    PackageView view = ((FrameworkElement)sender).DataContext as PackageView;
    
    PackageContents contents = new PackageContents(view.Name);
    contents.Show();
  }

  private string FormatCompression(uint flags)
  {
    switch ((ECompressionFlags)flags)
    {
      default: return "none";
      case ECompressionFlags.ZLIB: return "zlib";
      case ECompressionFlags.LZO: return "lzo";
      case ECompressionFlags.LZX: return "lzx";
    }
  }

  private string FormatFileSize(ulong size)
  {
    string[] sizeSuffixes =
    {
      "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"
    };

    const string formatTemplate = "{0}{1:0.#} {2}";

    if (size == 0)
    {
      return string.Format(formatTemplate, null, 0, sizeSuffixes[0]);
    }

    var absSize = Math.Abs((double)size);
    var fpPower = Math.Log(absSize, 1000);
    var intPower = (int)fpPower;
    var iUnit = intPower >= sizeSuffixes.Length
      ? sizeSuffixes.Length - 1
      : intPower;
    var normSize = absSize / Math.Pow(1000, iUnit);

    return string.Format(
      formatTemplate,
      size < 0 ? "-" : null, normSize, sizeSuffixes[iUnit]);
  }
}