using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem02
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam SubjectExam { get; set; }
        public void CreateExam()
        {
            Console.Write("Please Enter Type Of Exam You want To Create ( 1 for Practical and 2 for Final):");
            var Type = int.Parse(Console.ReadLine());
            var time = 0;
            switch (Type)
            {
                case 1:
                    SubjectExam = new PracticalExam();
                    Console.Write("Please Enter The Time Of Exam in Minutes: ");
                    time = int.Parse(Console.ReadLine());
                    SubjectExam.Time.AddMinutes(time);
                    SubjectExam.NumberOfQuestions = 1;
                    SubjectExam.Questions = new Question[1];
                    Console.Clear();
                    Console.WriteLine("MCQ Question\nPlease Enter The Bady of Question:");
                    SubjectExam.Questions[0] = new MCQQuestion();
                    SubjectExam.Questions[0].Body = Console.ReadLine();
                    Console.Write("Please Enter The Marks of Question:");
                    SubjectExam.Questions[0].Mark = int.Parse(Console.ReadLine());
                    Console.WriteLine("The Choices Of Question:");
                    for (int j = 0; j < 3; j++)
                    {
                        SubjectExam.Questions[0].Answers[j] = new Answer();
                        Console.Write($"Please Enter The Choice Number {j + 1}:");
                        var choice = Console.ReadLine();
                        SubjectExam.Questions[0].Answers[j].Id = j + 1;
                        SubjectExam.Questions[0].Answers[j].Text = choice;
                    }
                    Console.WriteLine("Please Specify The Right Choice of Question:");
                    SubjectExam.Questions[0].RightAnswer = new Answer();
                    SubjectExam.Questions[0].RightAnswer.Id = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    SubjectExam = new FinalExam();
                    Console.Write("Please Enter The Time Of Exam in Minutes: ");
                    time = int.Parse(Console.ReadLine());
                    SubjectExam.Time.AddMinutes(time);
                    Console.WriteLine("Please Enter The Number Of Question You Wanted To Create: ");
                    SubjectExam.NumberOfQuestions = int.Parse(Console.ReadLine());
                    SubjectExam.Questions = new Question[SubjectExam.NumberOfQuestions];
                    for (int i = 0; i < SubjectExam.NumberOfQuestions; i++)
                    {
                        Console.Clear();
                        Console.Write($"Please Choose The Type Of Question Number({i + 1}) (1 for True OR False || 2 for MCQ) : ");
                        Type = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (Type)
                        {
                            case 1:
                                SubjectExam.Questions[i] = new TrueOrFalse();
                                Console.WriteLine("True | False Question\nPlease Enter The Bady of Question:");
                                SubjectExam.Questions[i].Body = Console.ReadLine();
                                Console.Write("Please Enter The Marks of Question:");
                                SubjectExam.Questions[i].Mark = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please Enter The Right Answer of Question (1 for True and 2 for False):");
                                SubjectExam.Questions[i].Answers = new Answer[2]
                                {
                                    new Answer { Id = 1, Text = "True"},
                                    new Answer {  Id= 2, Text = "False"}
                                };
                                SubjectExam.Questions[i].RightAnswer = new Answer();
                                SubjectExam.Questions[i].RightAnswer.Id = int.Parse(Console.ReadLine());
                                break;
                            case 2:
                                SubjectExam.Questions[i] = new MCQQuestion();
                                Console.WriteLine("MCQ Question\nPlease Enter The Bady of Question:");
                                SubjectExam.Questions[i].Body = Console.ReadLine();
                                Console.Write("Please Enter The Marks of Question:");
                                SubjectExam.Questions[i].Mark = int.Parse(Console.ReadLine());
                                Console.WriteLine("The Choices Of Question:");
                                for (int j = 0; j < 3; j++)
                                {
                                    Console.Write($"Please Enter The Choice Number {j + 1}:");
                                    var choice = Console.ReadLine();
                                    SubjectExam.Questions[i].Answers[j] = new Answer();
                                    SubjectExam.Questions[i].Answers[j].Id = j + 1;
                                    SubjectExam.Questions[i].Answers[j].Text = choice;
                                }
                                SubjectExam.Questions[i].RightAnswer = new Answer();
                                Console.WriteLine("Please Specify The Right Choice of Question:");
                                var id = int.Parse(Console.ReadLine());
                                SubjectExam.Questions[i].RightAnswer.Id = id;
                                break;
                            default:
                                Console.WriteLine("Wrong choice. Come back later.");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Wrong choice. Come back later.");
                    break;
            }
        }

    }
}
