using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssureModel
{
    class SkillAssureTrainingModel
    {
        public List<Iteration> Iterations { get; set; } = new List<Iteration>(3);
        public string clientName { get; set; }

        public int getTotalAssessmentInTraining()
        {
            int TotalAssessment = 0;
            foreach (var iteration in Iterations)
            {
                TotalAssessment+= iteration.Assessments.Count;
            }
            return TotalAssessment;
        }
        public int getTotalScoreOfAllAssessments()
        {
            int totalScore = 0;
            foreach (var iteration in Iterations)
            {
                foreach (var assessment in iteration.Assessments)
                {
                    totalScore += assessment.getTotalMarks();
                }
            }
            return totalScore;
        }

        public int getNumMCQBasedAssessment()
        {
            int MCQquestions = 0;
            foreach (var iteration in Iterations )
            {
                foreach (var assessment in iteration.Assessments)
                {
                    foreach (var question in assessment.Questions)
                    {
                        if(question is MCQQuestions)
                        {
                            MCQquestions++;
                        }
                    }
                }
            }
            return MCQquestions;

        }

        public int getNumHandOnBasedAssessment()
        {
            int HandsOnquestions = 0;
            foreach (var iteration in Iterations)
            {
                foreach (var assessment in iteration.Assessments)
                {
                    foreach (var question in assessment.Questions)
                    {
                        if (question is HandsOnQuestion)
                        {
                            HandsOnquestions++;
                        }
                    }
                }
            }
            return HandsOnquestions;

        }

    }
}
