using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssureModel
{
    class Course
    {
        public List<Assessment> Assessments { get; set; } = new List<Assessment>();
        public string CourseId { get; set; }
        public string name { get; set; }
    }
}
