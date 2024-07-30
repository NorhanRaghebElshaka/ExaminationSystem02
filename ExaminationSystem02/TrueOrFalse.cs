using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem02
{
    public class TrueOrFalse : Question
    {
        public TrueOrFalse()
        {
            Answers = new Answer[2];
        }
        public override void DisplayQuestion()
        {
            Header = "True | False Question";
            Console.WriteLine($"{Header}\tMark({Mark}):\n{Body}\n");
            for (int i = 0; i < Answers.Length; i++)
            {
                Console.WriteLine(Answers[i]);
            }
        }
    }
}
