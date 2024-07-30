using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem02
{
    public class PracticalExam : Exam
    {
        public override void DisplayExam()
        {
            int rightAnswer = 0;
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
                Console.Write("-----------------------\nYour Answer :");
                rightAnswer = int.Parse(Console.ReadLine());
                Console.WriteLine("************************************");
            }
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine("Your Answers:");
                Console.WriteLine($"Q{i + 1})\t{Questions[i].Body}: {Questions[i].Answers[rightAnswer - 1].Text}");
            }
        }
    }
}
