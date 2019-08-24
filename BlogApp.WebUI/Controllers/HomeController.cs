using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private IBlogRepository blogRepository;

        public HomeController(IBlogRepository repository)
        {
            blogRepository = repository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(blogRepository.GetAll()) ;
        }
    }
}
