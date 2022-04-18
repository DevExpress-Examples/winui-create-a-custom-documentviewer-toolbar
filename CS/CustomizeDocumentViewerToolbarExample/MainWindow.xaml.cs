using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace CustomizeDocumentViewerToolbarExample
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            Frame frame = Content as Frame;
            frame.Navigate(typeof(Views.GridPage));
        }
    }
}
