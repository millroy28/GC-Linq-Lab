using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace GC_Linq_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            //Nums 1
            int minNum = nums.Min();
            Console.WriteLine("The lowest number is  " + minNum);
            
            //Nums 2
            int maxNum = nums.Max();
            Console.WriteLine("The highest number is  " + maxNum);
            
            //Nums 3
            int maxNumUnder10000 = nums.Where(n => n < 10000).Max();
            Console.WriteLine("The highest number under 10000 is  " + maxNumUnder10000);
            
            //Nums 4
            List<int> numBetween10and100 = nums.Where(n =>
            n > 10 &&
            n < 100).ToList();
            Console.WriteLine("The following are the numbers between 10 and 100:");
            foreach(int num in numBetween10and100)
            {
                Console.WriteLine(num);
            }

            //Nums 5
            List<int> numBetween100000and999999inc = nums.Where(n =>
            n >= 100000 &&
            n <= 999999).ToList();
            Console.WriteLine("The following are the numbers between 100000 and 999999:");
            foreach (int num in numBetween100000and999999inc)
            {
                Console.WriteLine(num);
            }

            //Nums 6
            int evenCount = nums.Where(n => n % 2 == 0).Count();
            Console.WriteLine("The number of even numbers is:  " + evenCount);

            //Students 1
            var ofDrinkingAge = from s in students
                                where s.Age >= 21
                                select s;
            List<Student> studentsOfDrinkingAge = ofDrinkingAge.ToList();
            Console.WriteLine("The following students are of drinking age:");
            foreach(Student student in studentsOfDrinkingAge)
            {
                Console.WriteLine(student.Name);
            }

            //Students 2
            Student oldestStudent = students.OrderByDescending(x => x.Age).First();
            Console.WriteLine("The oldest student is: " + oldestStudent.Name );

            //Students 3
            Student youngestStudent = students.OrderByDescending(x => x.Age).Last();
            Console.WriteLine("The youngest student is: " + youngestStudent.Name);

            //Students 4
            var studentsUnder25 = from s in students
                                            where s.Age < 25
                                            select s;
            Student oldestUnder25 = studentsUnder25.OrderByDescending(x => x.Age).First();
            Console.WriteLine("The oldest student under 25 is: " + oldestUnder25.Name);

            //Students 5
            List<Student> over21andEven = ofDrinkingAge.Where(x => x.Age % 2 == 0).ToList();
            Console.WriteLine("The following is a list of students over 21 with even ages: ");
            foreach (Student s in over21andEven)
            {
                Console.WriteLine(s.Name);
            }

            //Students 6
            List<Student> teenageStudents = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            Console.WriteLine("The following are a list of teenage students");
            foreach(Student student in teenageStudents)
            {
                Console.WriteLine(student.Name);
            }

            //Students 7
            var vowelNamed = from s in students
                             where s.Name.StartsWith("A") ||
                             s.Name.StartsWith("E") ||
                             s.Name.StartsWith("I") ||
                             s.Name.StartsWith("O") ||
                             s.Name.StartsWith("U")
                             select s;
            List<Student> vowelNamedStudents = vowelNamed.ToList();
            Console.WriteLine("The following is a list of students whose names being with a vowel: ");
            foreach(Student student in vowelNamedStudents)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
