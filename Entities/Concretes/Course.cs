using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstracts;

namespace Entities.Concretes
{
    public class Course : EntityBase
    {
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string Name { get; set; }
    }
}
