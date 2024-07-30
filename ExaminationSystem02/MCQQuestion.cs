using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem02
{
    public class MCQQuestion : Question
    {
        public MCQQuestion()
        {
            Answers = new Answer[3];
        }
        public override void DisplayQuestion()
        {
            Header = "Choose One Answer Question";
            Console.WriteLine($"{Header}\tMark({Mark}):\n{Body}\n");
            for (int i = 0; i < Answers.Length; i++)
            {
                Console.WriteLine(Answers[i]);
            }
        }
    }
}
