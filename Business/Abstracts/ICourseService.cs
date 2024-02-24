using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);
    }
}
