using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            Course course1 = new Course
            {
                Id = 1,
                CategoryId = 1,
                InstructorId = 1,
                Name = "C#"
            };

            Course course2 = new Course
            {
                Id = 2,
                CategoryId = 1,
                InstructorId = 1,
                Name = "Java"
            };

            Course course3 = new Course
            {
                Id = 3,
                CategoryId = 1,
                InstructorId = 1,
                Name = "SQL"
            };

            _courses = new List<Course>();

            _courses.Add(course1);
            _courses.Add(course2);
            _courses.Add(course3);
        }
        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course GetById(int id)
        {
           return _courses.SingleOrDefault(c=>c.Id == id);
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public void Update(Course course)
        {
            var updatedCourse = GetById(course.Id);
            updatedCourse.CategoryId = course.CategoryId;
            updatedCourse.InstructorId = course.InstructorId;
            updatedCourse.Name = course.Name;
        }
    }
}
