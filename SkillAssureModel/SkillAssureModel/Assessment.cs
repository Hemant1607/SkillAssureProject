using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssureModel
{
    class Assessment
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        public string AssessmentId { get; set; }
        public string description { get; set; }
        public int numberOfQuestions()
        {
            return Questions.Count;
        }
        public DateTime dtassessment { get; set; }
        public int getTotalMarks()
        {
            int TotalMarks = 0;
            foreach (var question in Questions)
            {
                TotalMarks += question.marks;
            }
            return TotalMarks;
        }

       
    }
}
