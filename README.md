# Reporting for WinUI - Customize the DocumentViewer Toolbar

This example creates a custom toolbar which contains the standard **DocumentViewer**'s commands, and adds the following commands to the toolbar:
- the **Back** and **Close** [AppBarButtons](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.appbarbutton)
- a link to this documentation page (a [HyperlinkButton](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.hyperlinkbutton) inside the [AppBarElementContainer](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.appbarelementcontainer)).

Run the application to see the following window that displays the data grid:

![Customize DocumentViewer Toolbar Example - Grid](/images/screenshot_grid.png)

Click **Show Print Preview** to invoke the window that contains the DocumentViewer displaying the report with the grid's data.

![Customize DocumentViewer Toolbar Example - DocumentViewer](/images/screenshot_documentviewer.png)

## Implementation Details

To create a [DocumentViewer](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer)'s custom command bar items, set the [ShowCommandBar](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer.ShowCommandBar) property to `false` and define a [CommandBar](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.commandbar) in XAML.
## Files to Look At

- [DocumentViewerPage.xaml](/CS/CustomizeDocumentViewerToolbarExample/Views/DocumentViewerPage.xaml)


## Documentation

- [DocumentViewer](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer?v=21.2)
- [Create a Custom DocumentViewer Toolbar](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer#create-a-custom-toolbar)
