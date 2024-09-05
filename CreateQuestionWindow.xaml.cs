using exam_creator.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace exam_creator
{
    /// <summary>
    /// Logica di interazione per CreateQuestionWindow.xaml
    /// </summary>
    public partial class CreateQuestionWindow : Window
    {
        public Question Question { get; private set; }
     
        /// <summary>
        /// Constructor.
        /// </summary>
        public CreateQuestionWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handle the click on button "Add" event. 
        /// </summary>
        /// <param name="sender">The event sender (button Add)</param>
        /// <param name="e"> The event </param>
        public void OnBtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (multipleChoicesCheckBox.IsChecked ?? false)
            {
                Question = new Question(questionText.Text, true, isSingleCorrectAnswerCheckBox.IsChecked ?? false, answerListCreator.Alternatives.ToList());
                DialogResult = true;
                Close();
            }
        }

        /// <summary>
        /// Handle the window closing event.
        /// </summary>
        /// <param name="sender">The sender object (the window itself)</param>
        /// <param name="e">The event args object</param>
        public void OnClosing(object sender, CancelEventArgs e)
        {
            if (DialogResult == true)
                return;

            if (answerListCreator.Alternatives.Count > 0 || questionText.Text.Length > 0)
            {
                var message = "Are you sure you want to close this window? You have unsaved changes that will be lost.";
                if (MessageBox.Show(message, "Warning", MessageBoxButton.YesNo) == MessageBoxResult.No)
                    e.Cancel = true;
            }
        }
    }
}
