using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class Grade
    {
        public int GradeID { get; set; }
        public int GradeScore { get; set; }
        public int GradePoint { get; set; }
        public char GradeRank { get; set; }
        public string GradeRemark { get; set; }

        //Grade Methods

        public string GetGrade(int gradeScore)
        {
            GradeScore = gradeScore;

            if (GradeScore >= 70)
            {
                GradePoint = 5;
                GradeRank = 'A';
                GradeRemark = "Excellent";
            }
            else if (GradeScore >= 60)
            {
                GradePoint = 4;
                GradeRank = 'B';
                GradeRemark = "Very Good";
            }
            else if (GradeScore >= 50)
            {
                GradePoint = 3;
                GradeRank = 'C';
                GradeRemark = "Good";
            }
            else if (GradeScore >= 45)
            {
                GradePoint = 2;
                GradeRank = 'D';
                GradeRemark = "Fair";
            }
            else if (GradeScore >= 40)
            {
                GradePoint = 1;
                GradeRank = 'E';
                GradeRemark = "Pass";
            }
            else
            {
                GradePoint = 0;
                GradeRank = 'F';
                GradeRemark = "Fail";
            }
            return ($"| {GradePoint} | {GradeRank} | {GradeRemark} |");
        }

        public bool IsValid()
        {
            var isValid = true;
            if (GradeScore < 0) isValid = false;
            return isValid;
        }
    }
}
