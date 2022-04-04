using DevExpress.WinUI.Grid.Printing;
using DevExpress.WinUI.Printing;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using DevExpress.WinUI.Grid;

namespace CustomizeDocumentViewerToolbar {

    public sealed partial class GridPage : Page {

        public GridPage() {
            InitializeComponent();
        }

        public ViewModel ViewModel { get; } = new ViewModel();

        void HyperlinkButton_Click(object sender, RoutedEventArgs e) {
            var documentSource = new PrintableLink(new GridControlPrinter(gridcontrol));

            // Customize a Document's Print Appearance
            documentSource.PageHeaderText = "Invoices";

            documentSource.PageHeaderStyle.FontSize = 20.0d;
            documentSource.PageHeaderStyle.Background = Colors.LightGreen;
            documentSource.PageHeaderStyle.Padding = new Thickness(10, 0, 0, 0);

            // Pass the created documentSource to the DocumentViewer as a parameter
            Frame.Navigate(typeof(DocumentViewerPage), documentSource, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }
    }
}
