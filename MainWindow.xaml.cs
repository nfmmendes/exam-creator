using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace exam_creator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new MainPage());
        }
    }
}