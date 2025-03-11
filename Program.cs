using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adding student ");
            Student std1 = new Student(1, "ali");
            Student std2 = new Student(2, "ahmed");
            Student std3 = new Student(3, "hamza");

            Console.WriteLine("adding teacher ");
            teacher teacher1 = new teacher(1, "asim", "oop");
            teacher teacher2 = new teacher(2, "talhaa", "maths");

           Console.WriteLine("managing school ");
            school sch = new school("allied school ", "grw", 20);

            Console.WriteLine("adding students to school");
            sch.addstudent(std1);
            sch.addstudent(std2);
            sch.addstudent(std3);

            Console.WriteLine("assigning grade to students ");
            teacher1.assigngrade(std1, 92);
            teacher1.assigngrade(std2, 10);
            teacher2.assigngrade(std3, 40);
            teacher2.assigngrade(std3, 20);

            Console.WriteLine("display average of grade of each student ");
            Console.WriteLine(std1.getname() + " has average " + std1.averagestudentgrade());
            Console.WriteLine($"{std2.getname ()} has average   {std2.averagestudentgrade()}");
            Console.WriteLine($"{std3.getname()} has average   {std3.averagestudentgrade()}");

            Console.WriteLine("display school information");
            Console.WriteLine(sch.getname());
            Console.WriteLine(sch.getLocation());

            foreach(Student std in sch.getstudent())
            {
                if (std != null)
                {


                    Console.WriteLine(std.getname());
                    Console.WriteLine(std.getstudentid());
                }
            }
            Console.ReadLine();
        }
    }
}
