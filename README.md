<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/422864203/21.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1040667)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WinUI DocumentViewer - Create a Custom Toolbar

To create a [DocumentViewer](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer)'s custom command bar items, set the [ShowCommandBar](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer.ShowCommandBar) property to `false` and define a [CommandBar](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.commandbar) in XAML prior to the **DocumentViewer** instance.

This example creates a custom toolbar with the standard **DocumentViewer**'s commands and adds the **Back** and **Close** [AppBarButtons](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.appbarbutton) and a link to this documentation page (a [HyperlinkButton](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.hyperlinkbutton) inside the [AppBarElementContainer](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.appbarelementcontainer)).

![CustomizeDocumentViewerToolbar_I9rOHbvzLC](https://user-images.githubusercontent.com/12169834/139530134-936bfd81-7f5d-497b-9eab-4472c6dfc7d5.png)

<!-- default file list -->
## Files to Look At

- [DocumentViewerPage.xaml](./CS/CustomizeDocumentViewerToolbar/CustomizeDocumentViewerToolbar/Views/DocumentViewerPage.xaml) (VB: [DocumentViewerPage.xaml](./VB/CustomizeDocumentViewerToolbar/CustomizeDocumentViewerToolbar/Views/DocumentViewerPage.xaml))
<!-- default file list end -->

## Documentation

- [DocumentViewer class description](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer)
- [Create a Custom DocumentViewer Toolbar](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer#create-a-custom-toolbar)
