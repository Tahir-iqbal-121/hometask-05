using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    internal class Student
    {
        private int studentid;
        private string name;
        private int[] grades;
        private int gradecount;

        public Student(int studentid, string name)
        {
            this.studentid = studentid;
            this.name = name;
            grades = new int[5];
            gradecount= 0;
        }

        public void setgrade(int grade)
        {
            grades[gradecount]=grade;
            gradecount++;
        }
        public double averagestudentgrade()
        {
            if (gradecount == 0) return 0;
                double sum = 0;

            for (int i = 0; i < gradecount; i++)
            {
                sum += grades[i];
            }
            return sum / gradecount;
        }
        public int getstudentid()
        {
            return studentid;
        }
        public string getname()
        {
            return name;
        }
    }
}
