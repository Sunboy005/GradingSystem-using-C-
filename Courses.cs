namespace GradingSystem
{
    public class Courses
    {
        public Courses()
        {

        }
        public Courses(int courseId)
        {
            this.CourseId = courseId;
        }
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public string CourseCode { get; set; }
        public float? CourseUnit { get; set; }

        //Method in Courses Class

        public void Retrieve(int courseId)
        {


        }

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(CourseName)) isValid = false;
            if (string.IsNullOrWhiteSpace(CourseCode)) isValid = false;
            if (CourseUnit < 0) isValid = false;

            return isValid;
        }
    }
}
