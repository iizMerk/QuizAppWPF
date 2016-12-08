using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Question
    {
        public int QuestionID { get; set; }

        public string QuestionText { get; set; }

        public string  Category { get; set; }

        public ICollection<Answear> Answears { get; set; } = new List<Answear>();

    }
}
