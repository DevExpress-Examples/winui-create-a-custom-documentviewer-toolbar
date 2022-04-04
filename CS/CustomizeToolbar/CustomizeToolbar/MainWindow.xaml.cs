using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace CustomizeDocumentViewerToolbar {
    public sealed partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Frame frame = Content as Frame;
            frame.Navigate(typeof(GridPage));
        }
    }
}
