using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterA
{
    class Student :IComparable<Student>
    {
        string name;
        Node<Course> coursesList;
        double averageGrade;

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, Node<Course> coursesList)
        {
            this.name = name;
            this.coursesList = coursesList;
            this.averageGrade = calculateAverage();
        }
        
        public double calculateAverage()
        {
            double sum = 0;
            Node<Course> currentCoursesList = coursesList;
            int numOfCourses = coursesList.NumberOfNodes();
            while(currentCoursesList!=null)
            {
                sum += currentCoursesList.GetValue().getCourseGrade();
                currentCoursesList = currentCoursesList.GetNext();
            }
            return sum / numOfCourses;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setCoursesList(Node<Course> coursesList)
        {
            this.coursesList = coursesList;
        }

        public Node<Course> getCoursesList()
        {
            return coursesList;
        }
        public override string ToString()
        {
            return $"Name:{name}, \n \tCourses:{coursesList}\n";
        }

        public void SetAverageGrade(double averageGrade)
        {
            this.averageGrade = averageGrade;
        }

        public double GetAverageGrade()
        {
            return averageGrade;
        }

        public int CompareTo(Student other)
        {
            if (this.averageGrade > other.averageGrade) return 1;
            else if (this.averageGrade < other.averageGrade) return -1;
            return 0;
        }

        
    }

}
