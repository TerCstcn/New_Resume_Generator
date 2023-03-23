using Microsoft.AspNetCore.Mvc;
using Resume.Models;

namespace Resume.Controllers
{
    public class SampleController : Controller
    {
        private readonly TupContext _tupContext;

        public SampleController(TupContext context )
        {
            _tupContext = context;
        }
        public IActionResult Index()
        {
            var student = _tupContext.Students.OrderByDescending(x => x.Id ).FirstOrDefault();
                        
            var vm = new HomeModel
            {
                Objectives = HomeController.Objectives,
                FirstName = student.FirstName,
                Surname = student.LastName,
                PlaceBirth = HomeController.PlaceBirth,
                DateBirth = HomeController.DateBirth,
                Gender = HomeController.Gender,
                Address = student.Address,
                ContactNumber = HomeController.ContactNumber,
                Email = student.Email,
                LinkedIn = HomeController.LinkedIn,
                Website = HomeController.Website,
                College = HomeController.College,
                CollegeAdd = HomeController.CollegeAdd,
                CollegeCourse = HomeController.CollegeCourse,
                CollegeGrad = HomeController.CollegeGrad,
                Highschool = HomeController.Highschool,
                HighschoolAdd = HomeController.HighschoolAdd,
                HighschoolStrand = HomeController.HighschoolStrand,
                HighschoolGrad = HomeController.HighschoolGrad,
            };
            return View(vm);
        }
    }
}
