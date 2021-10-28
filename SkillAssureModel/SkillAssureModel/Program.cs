using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssureModel
{
    class Program
    {
        static void Main(string[] args)
        {
            SkillAssureTrainingModel s = new SkillAssureTrainingModel();

            Iteration i1 = new Iteration();
            Iteration i2 = new Iteration();
            Iteration i3 = new Iteration();

            s.Iterations.Add(i1);
            s.Iterations.Add(i2);
            s.Iterations.Add(i3);

            Assessment a1 = new Assessment();
            Assessment a2 = new Assessment();
            Assessment a3 = new Assessment();
            

            i1.Assessments.Add(a1);
            i2.Assessments.Add(a2);
            i3.Assessments.Add(a3);


            Question q1 = new MCQQuestions { marks = 1 };
            Question q2 = new MCQQuestions { marks = 2 };
            Question q3 = new MCQQuestions { marks = 5 };
            Question q4 = new MCQQuestions { marks = 5 };
            Question q5 = new MCQQuestions { marks = 10 };
            Question q6 = new HandsOnQuestion { marks = 10 };
            Question q7 = new HandsOnQuestion { marks = 15 };
            Question q8 = new HandsOnQuestion { marks = 20 };
            Question q9 = new HandsOnQuestion { marks = 20 };
            Question q10 = new HandsOnQuestion { marks = 30 };

            a1.Questions.Add(q1);
            a1.Questions.Add(q3);
            a1.Questions.Add(q5);
            a1.Questions.Add(q6);
            a1.Questions.Add(q8);

            a2.Questions.Add(q2);
            a2.Questions.Add(q3);
            a2.Questions.Add(q4);
            a2.Questions.Add(q7);
            a2.Questions.Add(q9);

            a3.Questions.Add(q1);
            a3.Questions.Add(q2);
            a3.Questions.Add(q5);
            a3.Questions.Add(q9);
            a3.Questions.Add(q10);

            Console.WriteLine("Total number of assessments in training: " + s.getTotalAssessmentInTraining());
            Console.WriteLine("Total number of MCQ based assessments: " + s.getNumMCQBasedAssessment());
            Console.WriteLine("Total number of Hands On based assesment: " + s.getNumHandOnBasedAssessment());
            Console.WriteLine("Total score of all assessments: " + s.getTotalScoreOfAllAssessments());

            Console.ReadLine();
        }
    }
}
