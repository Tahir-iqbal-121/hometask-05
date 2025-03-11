using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    internal class teacher
    {
        private int  teacherid;
        private string teachername;
        private string subject;

        public teacher(int teacherid, string teachername, string subject)
        {
            this.teacherid = teacherid;
            this.teachername = teachername;
            this.subject = subject;
        }

        public void assigngrade(Student std,int grade)
        {
            std.setgrade(grade);
        }
        public string getteachername()
        {
            return teachername;
        }
        public string getteachersub()
        {
            return subject;
        }

    }
}
