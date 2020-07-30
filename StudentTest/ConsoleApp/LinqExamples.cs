using StudentTest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace StudentTest.ConsoleApp
{
    //public class LinqExamples
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            var lst = StudentRepository.GetAll();

    //            lst.Where(a => a.StudentId == 1).ToList();
    //            var minAge = lst.Min(a => a.Age);
    //            var maxAge = lst.Max(a => a.Age);
    //            var sumAge = lst.Sum(a => a.Age);
    //            var avgAge = lst.Average(a => a.Age);


    //            Console.WriteLine(minAge);
    //            Console.WriteLine(maxAge);
    //            Console.WriteLine(sumAge);
    //            Console.WriteLine(avgAge);


    //            // Distinct

    //            var lstTest1 = new List<string>() { "One", "Two", "One", "Three" };
    //            var resultTest1 = lstTest1.Distinct().ToList();

    //            //Order By
    //            //var resultOrder = lst.OrderByDescending(a => a.StudentId).ToList();
    //            var resultOrder = lst.OrderBy(a => a.FirstName).ThenBy(a => a.LastName).ToList();
    //            foreach (var item in resultOrder)
    //            {
    //                Console.WriteLine(item.StudentId + " => " + item.FirstName + " => " + item.LastName);
    //            }

    //            //All Or Any

    //            var boolList = new List<bool> { true, true, true, false };
    //            Console.WriteLine("--- Bool LIST ---");
    //            var resultA = boolList.All(a => a == true);
    //            var resultB = boolList.Any(a => a == true);
    //            Console.WriteLine(resultA);
    //            Console.WriteLine(resultB);

    //            Console.WriteLine("--- Find Index ---");

    //            //Find
    //            //var resultC = lst.FindIndex(a => a.StudentId == 3);
    //            var resultC = lst.FindIndex(a => a.StudentId == 4);
    //            Console.WriteLine(resultC);
    //        }
    //        catch (Exception ex)
    //        {
    //            var sb = new StringBuilder();
    //            sb.Append("Message \t" + ex.Message);
    //            sb.Append("\n StackTrace \t" + ex.StackTrace);
    //            sb.Append("\n InnerException \t" + ex.InnerException);

    //            Console.WriteLine(sb.ToString());
    //        }

    //        Console.ReadLine();
    //    }
    //}
}