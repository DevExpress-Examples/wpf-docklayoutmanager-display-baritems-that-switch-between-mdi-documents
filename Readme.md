<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642883/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T192029)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/dxSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/dxSample/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/dxSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/dxSample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to add a BarItem that allows switching between all opened MDI documents 


<p>The example illustrates how to add a BarItem with a collection of sub items, which will allow switching between all opened MDI documents in the DocumentGroup. This behavior can be achieved by binding <a href="https://documentation.devexpress.com/#wpf/DevExpressXpfBarsBarLinkContainerItem_ItemLinksSourcetopic">BarLinkContainerItem.ItemLinksSource</a> to the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingLayoutGroup_Itemstopic">DocumentGroup.Items</a> collection. Place the DataTemplate with the BarCheckItem control to the <a href="https://documentation.devexpress.com/#wpf/DevExpressXpfBarsBarLinkContainerItem_ItemTemplatetopic">BarLinkContainerItem.ItemTemplate</a> property. Bind the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfBarsBarItem_Contenttopic">BarCheckItem.Content</a> property to the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingBaseLayoutItem_Captiontopic">DocumentPanel.Caption</a> property to display DocumentPanel's header value in the BarItem's content. Set the <a href="https://documentation.devexpress.com/#wpf/DevExpressXpfBarsBarCheckItem_IsCheckedtopic">BarCheckItem.IsChecked</a> property to <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingBaseLayoutItem_IsActivetopic">DocumentPanel.IsActive</a> by using the Binding to allow switching between all DocumentPanels.</p>

<br/>


