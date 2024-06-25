
# WPF Dock Layout Manager - Add a BarItem that Switches Between All Opened MDI Documents

The example adds a [BarItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarItem) with a collection of sub items, that allow you to switch between all opened MDI documents in the [DocumentGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentGroup).

To do this, follow the steps below: 

1. Bind the [BarLinkContainerItem.ItemLinksSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarLinkContainerItem.ItemLinksSource) property to the [DocumentGroup.Items](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutGroup.Items) collection.

1. Place the DataTemplate with the [BarCheckItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarCheckItem) control into the [BarLinkContainerItem.ItemTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarLinkContainerItem.ItemTemplate) property.

1. Bind the [BarCheckItem.Content](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarItem.Content) property to the [DocumentPanel.Caption](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.BaseLayoutItem.Caption) property to display DocumentPanel's header value in the BarItem's content.

1. Bind the [BarCheckItem.IsChecked](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.BarCheckItem.IsChecked) property to the [DocumentPanel.IsActive](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.BaseLayoutItem.IsActive) property to allow users switch between [DocumentPanels](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel).


<img src="https://user-images.githubusercontent.com/12169834/175315170-4119eed7-965d-4f92-9da1-89bf5f907750.png" width=605px/>

<!-- default file list -->
## Files to Look At

* [MainWindow.xaml](./CS/dxSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/dxSample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/dxSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/dxSample/MainWindow.xaml.vb))
<!-- default file list end -->

## Documentation 

- [Multiple-Document Interface (MDI)](https://docs.devexpress.com/WPF/7209)

## More Examples

- [WPF Dock Layout Manager - Enable MDI Mode for a DocumentGroup](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-enable-a-documentgroups-mdi-mode)
