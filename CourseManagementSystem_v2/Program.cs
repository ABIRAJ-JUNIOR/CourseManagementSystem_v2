using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _courseRepository = new CourseRepository();

            bool exit = true;
            while (exit)
            {
                Console.Clear();
                Console.WriteLine("--- Course Management System ---");
                Console.WriteLine("1. Add a Course");
                Console.WriteLine("2. View All Courses");
                Console.WriteLine("3. Update a Courses");
                Console.WriteLine("4. Delete a Course");
                Console.WriteLine("5. Exit");
                Console.Write("\nChoose an Option : ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("-- Add a Course --\n");
                        Console.Write("Enter Course ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Enter Course Title: ");
                        string title = _courseRepository.CapitalizeTitle(Console.ReadLine());
                        Console.Write("Enter Course Duration: ");
                        string duration = Console.ReadLine();
                        Console.Write("Enter Course price: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        _courseRepository.Insert(id, title, duration, price);
                        break;
                    case "2":
                        Console.Clear();
                        _courseRepository.GetAllCourses();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("-- Update a Course --\n");
                        Console.Write("Enter Course ID: ");
                        string Courseid = Console.ReadLine();
                        Console.Write("Enter Course Title: ");
                        string newtitle = _courseRepository.CapitalizeTitle(Console.ReadLine());
                        Console.Write("Enter Course Duration: ");
                        string newduration = Console.ReadLine();
                        Console.Write("Enter Course price: ");
                        decimal newprice = decimal.Parse(Console.ReadLine());
                        _courseRepository.Update(Courseid, newtitle, newduration, newprice);

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("-- Delete a Course --\n");
                        Console.Write("Enter Course ID: ");
                        string DeleteCourseid = Console.ReadLine();
                        _courseRepository.Delete(DeleteCourseid);

                        break;
                    case "5":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

                if (option != "5")
                {
                    Console.WriteLine("\nPress any Key to Continue..");
                    Console.ReadKey();
                }

            }
        }
    }
}
