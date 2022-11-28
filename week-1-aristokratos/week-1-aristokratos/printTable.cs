using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1_aristokratos
{
    public class printTable
    {
        int score, grade, point, courseUnit, numberOfCourses, weightedPoint;
        double CGPA;
        string courseCode;
        string userName;
        string course = "";
        string result = "";
        List<string> courseFolder = new List<string>();
        List<string> courseCodeFolder = new List<string>();
        List<int> scoreFolder = new();
        List<char> gradeFolder = new List<char>();
        List<string> remarkFolder = new List<string>();
        List<int> courseUnitFolder = new List<int>();
        List<int> gradeUnitFolder = new List<int>();
        List<int> weightedPointFolder = new List<int>();

        public void table()
        {
            
            
                Console.WriteLine("|--------------|------------|-------------|---------|--------------|----------------------|");
                Console.WriteLine("|Course & Code |COURSE Unit |Grade  Unit  |Grade    |Weighted Point|  Remark |\t          |");        
                Console.WriteLine("|--------------|------------|-------------|---------|--------------|----------------------|");
                for (int i = 0; i < numberOfCourses; i++)
                {
                   Console.WriteLine($"\t| {courseFolder[i] + courseCodeFolder[i]}  \t| {courseUnitFolder[i]}  \t| {gradeUnitFolder[i]}  \t|{gradeFolder[i]}   \t|\t{weightedPointFolder[i]}    \t |\t{remarkFolder[i]} \t|");
                }
                Console.WriteLine("|--------------|------------|-------------|---------|--------------|----------------------|");
                Console.WriteLine($"Total Grade Unit Register is {courseUnit}");
                Console.WriteLine($"Total Grade Unit Passed is {grade}");
                Console.WriteLine($"Total Weight Point is {weightedPoint}");
                Console.WriteLine($"Your CGPA is {CGPA} to 2 decimal places");
                Console.WriteLine($"{result}");


                Console.WriteLine("Thank you for using the CGPA calculator, we hope to see you soon. Success!!!");
            

        }
    }
}
