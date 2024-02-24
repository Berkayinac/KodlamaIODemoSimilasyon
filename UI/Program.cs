using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;


// COURSE CRUD
Course course = new Course();
course.Id = 4;
course.InstructorId = 1;
course.CategoryId = 1;
course.Name = "Test";

ICourseDal courseDal = new CourseDal();
ICourseService courseService = new CourseManager(courseDal);
GetAllCourses();

courseService.Add(course);
GetAllCourses();

course.Name = "TestV2";
courseService.Update(course);
GetAllCourses();

courseService.Delete(course);
GetAllCourses();


Console.WriteLine("-------------------------------");
Console.WriteLine("-------------------------------");
Console.WriteLine("-------------------------------");

// INSTRUCTOR CRUD
Instructor instructor = new Instructor();
instructor.Id = 3;
instructor.FirstName = "Berkay";
instructor.LastName = "İnaç";
instructor.Description = "Junior full stack developer";

IInstructorDal instructorDal = new InstructorDal();
IInstructorService instructorService = new InstructorManager(instructorDal);

GetAllInstructors();

instructorService.Add(instructor);
GetAllInstructors();

instructor.FirstName = "Kaan";
instructorService.Update(instructor);
GetAllInstructors();

instructorService.Delete(instructor);
GetAllInstructors();

Console.WriteLine("-------------------------------");
Console.WriteLine("-------------------------------");
Console.WriteLine("-------------------------------");

// CATEGORY CRUD
Category category = new Category();
category.Id = 3;
category.Name = "Bulut";

ICategoryDal categoryDal = new CategoryDal();
ICategoryService categoryService = new CategoryManager(categoryDal);

GetAllCategories();

categoryService.Add(category);
GetAllCategories();

category.Name = "Bulut Bilişim";
categoryService.Update(category);
GetAllCategories();

categoryService.Delete(category);
GetAllCategories();



void GetAllCategories()
{
    Console.WriteLine("-------------------------");
    foreach (var categoryItem in categoryService.GetAll())
    {
        Console.WriteLine("Id: " + categoryItem.Id);
        Console.WriteLine("Name: " + categoryItem.Name);
    }
}


void GetAllInstructors()
{
    Console.WriteLine("-------------------------");
    foreach (var instructorItem in instructorService.GetAll())
    {
        Console.WriteLine("Id: " + instructorItem.Id);
        Console.WriteLine("FirstName: " + instructorItem.FirstName);
        Console.WriteLine("LastName: " + instructorItem.LastName);
        Console.WriteLine("Description: " + instructorItem.Description);
    }
}


void GetAllCourses()
{
    Console.WriteLine("-------------------------");
    foreach (var courseItem in courseService.GetAll())
    {
        Console.WriteLine("Id: " + courseItem.Id);
        Console.WriteLine("CategoryId:" + courseItem.CategoryId);
        Console.WriteLine("InstructorId: " + courseItem.InstructorId);
        Console.WriteLine("Name: " + courseItem.Name);
    }
}
