using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnitLab1
{
    public class Question
    {
        public string Text { get; set; }
        public int Mark { get; set; }

        public Question(string text, int mark)
        {
            Text = text;
            Mark = mark;
        }


        public override string ToString()
        {
            return $"Question: {Text}, Mark: {Mark}";
        }
    }
}
