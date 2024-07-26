using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace exam_creator.Data
{
    /// <summary>
    /// Class <c>QuestionAlternative</c> is used to describe an alternative in
    /// a multiple choice question. 
    /// </summary>
    public class QuestionAlternative
    {
        /// <value>
        /// The text of the alternative. This value can be null if the 
        /// alternative is represented by an image. 
        /// </value>
        public string? Text { get; set; }

        /// <value>
        /// True if this alternative is correct. False otherwise. 
        /// </value>
        public bool IsCorrect { get; set; }

        /// <value>
        /// The image that represents the image. This value can be null if the alternative
        /// is represented by a text. 
        /// </value>
        public string? Image { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public QuestionAlternative() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="text"> The alternative text. </param>
        /// <param name="isCorrect"> True if the alternative is correct, false otherwise. </param>
        /// <param name="image"> The alternative image.</param>
        public QuestionAlternative(string? text, bool isCorrect, string? image)
        {
            Text = text;
            IsCorrect = isCorrect;
            Image = image;
        }
    }
}
