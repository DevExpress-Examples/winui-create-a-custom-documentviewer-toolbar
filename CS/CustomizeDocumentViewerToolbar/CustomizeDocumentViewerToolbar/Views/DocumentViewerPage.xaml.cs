using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace CustomizeDocumentViewerToolbar {
    public sealed partial class DocumentViewerPage : Page {
        public DocumentViewerPage() {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            if (e.Parameter is not null)
                documentViewer.DocumentSource = e.Parameter;
            base.OnNavigatedTo(e);
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e) => Frame.GoBack();
    }
}
