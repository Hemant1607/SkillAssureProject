using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssureModel
{
    abstract class Question
    {
        public virtual int marks { get; set; }
    }

    class MCQQuestions : Question
    {
        public override int marks{get;set;}
        public string questionName { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        public string rightOption { get; set; }

    }

    class HandsOnQuestion : Question
    {
        public override int marks { get; set; }
        public string questionDesc { get; set; }
        public string referenceDocumnt { get; set; }
    }
}
