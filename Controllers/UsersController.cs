using collections.Enums;
using collections.Models;
using collections.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using collections.ViewModels.Users;

namespace collections.Controllers {
    public class UsersController : Controller
    {
        private readonly IUsers _users;

        public UsersController(IUsers users)
        {
            _users = users;
        }

        [Route("/users/index")]
        public IActionResult index()
        {
            string orderBy = HttpContext.Request.Query["orderBy"];
            if(orderBy == null) orderBy = "id";

            string order = HttpContext.Request.Query["order"];
            if(order == null) order = SortingEnum.ASC;

            IndexViewModels viewModels = new IndexViewModels(
                _users.AllOrdered(orderBy, order), orderBy, order);

            return View(viewModels);
        }

        [Route("/users/create")]
        public IActionResult create()
        {
            return View();
        }

        [HttpGet]
        [Route("/users/update/{id:int}")]
        public IActionResult update(int id)
        {
            List<User> users = new List<User>(_users.All);
            User user = users.Find(x => x.id == id);

            return View(new UpdateViewModels(user));
        }

        [HttpPost]
        [Route("/users/update")]
        public RedirectResult update(User user)
        {
            HashSet<User> users = new HashSet<User>(_users.All);
            users.Add(user);

            _users.All = users;
            return Redirect("/users/update/" + user.id);
        }

        [HttpPost]
        [Route("/users/delete/{id:int}")]
        public ActionResult delete(int id)
        {
            _users.RemoveById(id);
            return Redirect("/users/index");
        }
    }
}