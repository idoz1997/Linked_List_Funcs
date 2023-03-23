using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterA
{
    class Course
    {
        int courseCode;
        int courseGrade;

        public Course(int courseCode, int courseGrade)
        {
            this.courseCode = courseCode;
            this.courseGrade = courseGrade;
        }

        public void setCourseCode(int courseCode)
        {
            this.courseCode = courseCode;
        }

        public int getCourseCode()
        {
            return courseCode;
        }

        public void setCourseGrade(int courseGrade)
        {
            this.courseGrade = courseGrade;
        }

        public int getCourseGrade()
        {
            return courseGrade;
        }

        public override string ToString()
        {
            string str = $"\n Course Code: {courseCode}, Grade: {courseGrade}";
            return str;
        }

    }
}
