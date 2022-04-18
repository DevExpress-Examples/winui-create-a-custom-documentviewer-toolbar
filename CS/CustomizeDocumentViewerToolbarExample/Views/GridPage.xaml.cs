using DevExpress.WinUI.Grid.Printing;
using DevExpress.WinUI.Printing;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CustomizeDocumentViewerToolbarExample.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GridPage : Page
    {
        public GridPage()
        {
            this.InitializeComponent();
        }

        public ViewModel ViewModel { get; } = new ViewModel();

        void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            var documentSource = new PrintableLink(new GridControlPrinter(gridcontrol));

            documentSource.PageHeaderText = "Invoices";

            documentSource.PageHeaderStyle.FontSize = 20.0d;
            documentSource.PageHeaderStyle.Background = Colors.LightGreen;
            documentSource.PageHeaderStyle.Padding = new Thickness(10, 0, 0, 0);

            Frame.Navigate(typeof(DocumentViewerPage), documentSource, 
                new SlideNavigationTransitionInfo() {
                    Effect = SlideNavigationTransitionEffect.FromRight 
                });
        }
    }
}
