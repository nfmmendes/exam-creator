using exam_creator.Data;
using Microsoft.Win32;
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
    /// Class <c>AnswerOptionsListCreator</c> is a control to create a list of alternatives of a question.
    /// </summary>
    public partial class AnswerOptionsListCreator : UserControl
    {
        /// <value>
        /// The list of alternatives
        /// </value>
        public ObservableCollection<QuestionAlternative> Alternatives { get; set; }

        /// <value>
        /// Defines if the alternatives are images. The default value is false. 
        /// </value>
        public bool IsImageList { get; set; } = false;

        /// <summary>
        /// Static constructor. 
        /// </summary>
        public AnswerOptionsListCreator()
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
            var alternative = new QuestionAlternative();
            if (IsImageList)
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.svg)|*.jpg;*.jpeg;*.png;*.svg";
                if (dialog.ShowDialog() == true)
                {
                    alternative.Image = dialog.FileName;
                    MessageBox.Show(alternative.Image);
                }
            }

            Alternatives.Add(alternative);
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
