using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using System.Diagnostics;
using System.Reflection;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        private readonly TupContext _tupContext;
        private readonly ILogger<HomeController> _logger;

        public static string Objectives = "";
        public static string FirstName = "";
        public static string MiddleName = "";
		public static string Surname = "";
		public static string PlaceBirth = "";
        public static string DateBirth = "";
        public static string Gender = "";
        public static string Address = "";
        public static string ContactNumber = "";
        public static string Email = "";
        public static string LinkedIn = "";
        public static string Website = "";
        public static string College = "";
        public static string CollegeAdd = "";
        public static string CollegeCourse = "";
        public static string CollegeGrad = "";
        public static string Highschool = "";
        public static string HighschoolAdd = "";
        public static string HighschoolStrand = "";
        public static string HighschoolGrad = "";

        public HomeController(ILogger<HomeController> logger, TupContext context)
        {
            _logger = logger;
            _tupContext = context;
        }

        public IActionResult Index()
        {
            var vm = new HomeModel();
            vm.Objectives = "";
            vm.FirstName = "";
            vm.MiddleName = "";
            vm.Surname = "";
            vm.PlaceBirth = "";
            vm.DateBirth = "";
            vm.Gender = "";
            vm.Address = "";
            vm.ContactNumber = "";
            vm.Email = "";
            vm.LinkedIn = "";
            vm.Website = "";
            vm.College = "";
            vm.CollegeAdd = "";
            vm.CollegeCourse = "";
            vm.CollegeGrad = "";
            vm.Highschool = "";
            vm.HighschoolAdd = "";
            vm.HighschoolStrand = "";
            vm.HighschoolGrad = "";

            return View(vm);
        }

        [HttpPost]
        public IActionResult Insert(HomeModel model)
        {
            Objectives = model.Objectives;
            FirstName = model.FirstName;
            MiddleName = model.MiddleName;
            Surname = model.Surname;
            PlaceBirth = model.PlaceBirth;
            DateBirth = model.DateBirth;
            Gender = model.Gender;
            Address = model.Address;
            ContactNumber = model.ContactNumber;
            Email = model.Email;
            LinkedIn = model.LinkedIn;  
            Website = model.Website;
            College = model.College;
            CollegeAdd = model.CollegeAdd;
            CollegeCourse = model.CollegeCourse;
            CollegeGrad = model.CollegeGrad;
            Highschool = model.Highschool;  
            HighschoolAdd = model.HighschoolAdd;
            HighschoolStrand = model.HighschoolStrand;
            HighschoolGrad = model.HighschoolGrad;

            var student = new Student()
            {
                 
                 Address = model.Address,
                 FirstName = model.FirstName,
                 MiddleName = model.MiddleName,
                 LastName = model.Surname,
                 Contact = model.ContactNumber,
                 Objectives = model.Objectives,
                 Email = model.Email,
                  
                 
            };

             _tupContext.Add(student);
             _tupContext.SaveChanges();

            return RedirectToAction("Index", "Sample");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}