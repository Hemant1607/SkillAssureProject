using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssureModel
{
    class Iteration
    {
        public List<Assessment> Assessments { get; set; } = new List<Assessment>();
        public Course course { get; set; }
        public int iterationNumber { get; set; }
        public string goal { get; set; }
    }
}
