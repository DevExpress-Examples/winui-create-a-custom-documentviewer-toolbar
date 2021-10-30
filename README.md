# WinUI DocumentViewer - Create a Custom Toolbar

To create a [DocumentViewer](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer)'s custom command bar items, set the [ShowCommandBar](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer.ShowCommandBar) property to `false` and define a [CommandBar](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.commandbar) in XAML prior to the **DocumentViewer** instance.

This example creates a custom toolbar with the standard **DocumentViewer**'s commands and adds the **Back** and **Close** [AppBarButtons](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.appbarbutton) and a link to this documentation page (a [HyperlinkButton](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.hyperlinkbutton) inside the [AppBarElementContainer](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.appbarelementcontainer)).

<!-- default file list -->
## Files to Look At

- [DocumentViewerPage.xaml](./CS/CustomizeDocumentViewerToolbar/CustomizeDocumentViewerToolbar/Views/DocumentViewerPage.xaml) (VB: [DocumentViewerPage.xaml](./VB/CustomizeDocumentViewerToolbar/CustomizeDocumentViewerToolbar/Views/DocumentViewerPage.xaml))
<!-- default file list end -->

## Documentation

- [DocumentViewer class description](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer)
- [Create a Custom DocumentViewer Toolbar](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer#create-a-custom-toolbar)
