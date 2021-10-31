using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class CoursesRepo
    {
        public Courses Retrieve(int courseId)
        {
            Courses newCourse = new Courses(courseId);

            if (courseId == 1)
            {
                newCourse.CourseCode = "LNG201";
                newCourse.CourseName = "French for Dummy";
                newCourse.CourseUnit = 2;
            }
            //To retrieve a customer from ID
            return newCourse;
        }

        //Save User
        public bool Save()
        {
            //To Save a User details


            return true;
        }
    }
}
