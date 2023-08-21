using BlogApp.Data;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class UserController : Controller
    {
        private readonly MvcBlogContext _context;

        public UserController(MvcBlogContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<User> users = _context.Users.ToList();
            return View(users);
        }
    }
}
