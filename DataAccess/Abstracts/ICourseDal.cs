using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);
    }
}
