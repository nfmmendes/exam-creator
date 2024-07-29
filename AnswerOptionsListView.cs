using exam_creator.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
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
    /// Class <c>AnswerOptionsListView</c> is a control to create a list of alternatives of a question.
    /// </summary>
    public partial class AnswerOptionsListView : UserControl
    {
        public ObservableCollection<QuestionAlternative> Alternatives { get; set; }

        /// <summary>
        /// Static constructor. 
        /// </summary>
        public AnswerOptionsListView()
        {
            InitializeComponent();
            DataContext = this;
            Alternatives = new ObservableCollection<QuestionAlternative>();
        }

        /// <summary>
        /// Handles the "Add Alternative" button click event.
        /// </summary>
        /// <param name="sender"> The event sender object. </param>
        /// <param name="e"> The event args. </param>
        void OnBtnAddAlternative_Click(object sender, RoutedEventArgs e)
        {
            Alternatives.Add(new QuestionAlternative());
        }

        /// <summary>
        /// Handles the delete icon mouse down event. 
        /// </summary>
        /// <param name="sender"> The event sender object. </param>
        /// <param name="e"> The event args. </param>
        void OnDeleteIcon_MouseDown(object sender, MouseButtonEventArgs e) {
            var button = (Image)sender;
            var item = (QuestionAlternative)button.Tag;

            Alternatives.Remove(item);
        }
    }
}
