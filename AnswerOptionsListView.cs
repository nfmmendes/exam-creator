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
    /// Class <c>AnswerOptionsListView</c> is a control to create a list of alternatives of a question.
    /// </summary>
    public class AnswerOptionsListView : Control
    {
        /// <summary>
        /// Static constructor. 
        /// </summary>
        static AnswerOptionsListView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AnswerOptionsListView), new FrameworkPropertyMetadata(typeof(AnswerOptionsListView)));
        }
    }
}
