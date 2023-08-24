using System;

namespace StudentGrades
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Get Percentage 
            var gradeCalculator = new GradeCalculator();

            Console.Write("Enter The Percentage : ");

            var percentage = Convert.ToInt32(Console.ReadLine());

            var grade = gradeCalculator.GetGradeByPercentage(percentage);

            // print Grade
            Console.WriteLine($"Student Grade : {grade}");
        }
    }
}
