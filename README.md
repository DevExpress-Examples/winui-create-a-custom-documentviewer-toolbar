<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/422864203/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1040667)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WinUI DocumentViewer - Create a Custom Toolbar

To create a [DocumentViewer](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer)'s custom command bar items, set the [ShowCommandBar](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer.ShowCommandBar) property to `false` and define a [CommandBar](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.commandbar) in XAML prior to the **DocumentViewer** instance.

This example creates a custom toolbar with the standard **DocumentViewer**'s commands and adds the **Back** and **Close** [AppBarButtons](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.appbarbutton) and a link to this documentation page (a [HyperlinkButton](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.hyperlinkbutton) inside the [AppBarElementContainer](https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.controls.appbarelementcontainer)).

![CustomizeDocumentViewerToolbar_I9rOHbvzLC](https://user-images.githubusercontent.com/12169834/139530134-936bfd81-7f5d-497b-9eab-4472c6dfc7d5.png)

<!-- default file list -->
## Files to Look At

- [DocumentViewerPage.xaml](./CS/CustomizeToolbar/CustomizeToolbar/Views/DocumentViewerPage.xaml)
<!-- default file list end -->

## Documentation

- [DocumentViewer class description](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer)
- [Create a Custom DocumentViewer Toolbar](https://docs.devexpress.com/WinUI/DevExpress.WinUI.DocumentViewer.DocumentViewer#create-a-custom-toolbar)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winui-create-a-custom-documentviewer-toolbar&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winui-create-a-custom-documentviewer-toolbar&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
