using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_creator.Data
{
    /// <summary>
    /// Class <c>Question</c> holds the text and alternatives of a question.
    /// </summary>
    public class Question
    {
        /// <value>
        /// Defines if the question is a multiple choices question
        /// </value>
        public bool IsMultipleChoices { get; set; }

        /// <value>
        /// Define if the question has a single answer. 
        /// </value>
        public bool IsSingleChoice { get; set; }

        /// <value>
        /// The text of the question. 
        /// </value>
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// The list of alternatives, to a multiple choices question. 
        /// </summary>
        public List<QuestionAlternative> Alternatives { get; set; } = new List<QuestionAlternative>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public Question() { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="text"> The question text.</param>
        /// <param name="isMultipleChoices"> True if the question is a multiple choices question, false otherwise. </param>
        /// <param name="isSingleChoice"> True if the question has a single answer, false otherwise. </param>
        /// <param name="alternatives"> Lists of alternatives in a multiple choiches question. </param>
        public Question(string text, bool isMultipleChoices, bool isSingleChoice, List<QuestionAlternative>? alternatives = null)
        {
            IsMultipleChoices = isMultipleChoices;
            IsSingleChoice = isSingleChoice;
            Text = text;

            if (alternatives != null)
            {
                Alternatives = alternatives;
            }
        }
    }
}
