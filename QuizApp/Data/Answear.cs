using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Answear
    {
        public int AnswearID { get; set; }
        public string AnswearText { get; set; }
        public bool Correct { get; set; }
        public int Point { get; set; }
        public int QuestionID { get; set; }
    }
}
