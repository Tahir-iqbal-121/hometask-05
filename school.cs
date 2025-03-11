using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    internal class school
    {
        private string schoolname;
        private string location;
        private Student[] students ;
        private int studentcount;

        public school(string schoolname,string location ,int maxstudent)
        {
            this.schoolname = schoolname;
            this.location = location;
            students = new Student[maxstudent];
            studentcount= 0;
        }
        public void addstudent(Student student)
        {
            students[studentcount]= student;
            studentcount++;
        }
        public string getname()
        {
            return schoolname;
        }
        public string getLocation()
        {
            return location;
        }
        public Student[] getstudent()
        {
            return students;
        }
    }
}
