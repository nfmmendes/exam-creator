using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace exam_creator
{
    /// <summary>
    /// Logica di interazione per MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnCreateNewExam_Click(object sender, RoutedEventArgs e)
        {
            var createNewWindow = new CreateExamWindow();
            createNewWindow.ShowDialog();
        }

        private void BtnOpenExam_Click(object sender, RoutedEventArgs e)
        {
            var _ = MessageBox.Show($"{BtnOpenExam.Content} button clicked");
        }

        private void BtnCreateNewQuestion_Click(object sender, RoutedEventArgs e)
        {
            var createNewQuestionWindow = new CreateQuestionWindow();
            createNewQuestionWindow.ShowDialog();
        }
    }
}
