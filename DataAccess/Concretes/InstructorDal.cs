using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Description = "Senior Developer"
            };

            Instructor instructor2 = new Instructor
            {
                Id = 2,
                FirstName = "Kerem",
                LastName = "Varış",
                Description = "Senior Developer"
            };


            _instructors = new List<Instructor>();

            _instructors.Add(instructor1);
            _instructors.Add(instructor2);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
           return _instructors.SingleOrDefault(i => i.Id == id);
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public void Update(Instructor instructor)
        {
            var updatedInstructor = GetById(instructor.Id);
            updatedInstructor.FirstName = instructor.FirstName;
            updatedInstructor.LastName = instructor.LastName;
            updatedInstructor.Description = instructor.Description;
        }
    }
}
