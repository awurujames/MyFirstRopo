using System;

namespace GradeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade grade = new Grade();

            Console.Write("Please Enter Name: ");
            grade.name = Console.ReadLine();

            Console.Write("Please Enter Score");
            int score = Convert.ToInt32(Console.ReadLine());
            grade.Score(score);

            Console.WriteLine($"Thank you {grade.Name}!\nYour grade is {grade.Score()}");
        }
    }
}
