using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ue3;

namespace ue3explorer;

public partial class PackageContents : Window
{
  protected override void OnSourceInitialized(EventArgs e)
  {
    base.OnSourceInitialized(e);
    App.UseImmersiveDarkMode(this);
  }

  class EntryView
  {
    public int Index { get; set; }
    public string Outer { get; set; }
    public string Class { get; set; }
    public string Name { get; set; }
    public double SizeOnDiskKiB { get; set; }
    public string Flags { get; set; }
  }

  private TextBox filterInput;
  private ObservableCollection<EntryView> entries = new();
  private CollectionViewSource entriesSourceList;

  public PackageContents(string Name)
  {
    InitializeComponent();
    Title = "UE3xplorer - " + Name;

    if (!UObject.GObjLoaders.ContainsKey(Name))
    {
      Close();
      return;
    }

    loader = UObject.GObjLoaders[Name];

    Progress.Maximum = loader.Summary.ExportCount;
    EntriesDataGrid.AutoGenerateColumns = false;
    entriesSourceList = new() { Source = entries };
    EntriesDataGrid.ItemsSource = entriesSourceList.View;
    Task.Run(LoadPackage);
  }

  private ULinkerLoad loader;

  private void LoadPackage()
  {
    loader.LoadImportExports();

    int index = 0;
    foreach (ULinker.FObjectExport export in loader.Exports)
    {
      EntryView view = new();

      view.Index = index++;

      if (export.OuterIndex != 0)
        view.Outer = loader.GetEntryClass(export.OuterIndex).Resolved + "'" + loader.GetEntryName(export.OuterIndex).Resolved;
      else view.Outer = "None";

      view.Class = loader.GetEntryName(export.ClassIndex).Resolved;
      view.Name = export.ObjectName.Resolved;
      view.SizeOnDiskKiB = export.SerialSize / 1024.0;
      view.Flags = ((EObjectFlags)export.ObjectFlags).ToString();

      Application.Current.Dispatcher.Invoke(() =>
      {
        entries.Add(view);
        Progress.Value = entries.Count;
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
      string query = filterInput.Text.ToLower();
      entriesSourceList.View.Filter = item => ((EntryView)item).Name.ToLower().Contains(query);
    }
    else
    {
      entriesSourceList.View.Filter = null;
    }
  }

  private void PackageContent_Click(object sender, RoutedEventArgs e)
  {
    EntryView view = ((FrameworkElement)sender).DataContext as EntryView;
    UObject Obj = loader.LoadExport(loader.Exports[view.Index]);
    loader.FullyLoadObject(Obj);
  }
}