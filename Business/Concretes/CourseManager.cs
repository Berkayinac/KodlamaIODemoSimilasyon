using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
