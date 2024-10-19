using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnitLab1
{
    public class Answer
    {
        public int Number { get; set; }
        public string Text { get; set; }

        public Answer(int number, string text)
        {
            Number = number;
            Text = text;
        }



        public override string ToString()
        {
            return $"{Number}-{Text} ";
        }
    }
}
