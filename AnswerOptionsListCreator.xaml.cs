using exam_creator.Data;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
        /// Defines a dependencce property to enable using IsImageList as a xaml attribute. 
        /// </value>
        private static readonly DependencyProperty IsImageListProperty = DependencyProperty.Register(
          name: "IsImageList",
          propertyType: typeof(bool),
          ownerType: typeof(AnswerOptionsListCreator),
          typeMetadata: new FrameworkPropertyMetadata(
              defaultValue: false,
              flags: FrameworkPropertyMetadataOptions.AffectsRender)
        );

        /// <value>
        /// Defines if the alternatives are images. The default value is false. 
        /// </value>
        public bool IsImageList {
            get => (bool)GetValue(IsImageListProperty);
            set => SetValue(IsImageListProperty, value);
        }

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
                if (!dialog.ShowDialog() ?? false)
                    return;

                alternative.Image = dialog.FileName;
                var dialogResult = MessageBox.Show(alternative.Image);
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
