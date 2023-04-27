using pizza.Enums;
using pizza.Models;
using pizza.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using pizza.ViewModels.Users;

namespace pizza.Controllers {
    public class ItemsController : Controller
    {
        private readonly IItems _items;

        public ItemsController(IItems items)
        {
            _items = items;
        }

        [Route("/items/index")]
        public IActionResult index()
        {
            string orderBy = HttpContext.Request.Query["orderBy"];
            if(orderBy == null) orderBy = "id";

            string order = HttpContext.Request.Query["order"];
            if(order == null) order = SortingEnum.ASC;

            IndexViewModels viewModels = new IndexViewModels((List<User>)_items.All);
            return View(viewModels);
        }

        [Route("/items/create")]
        public IActionResult create()
        {
            return View();
        }

        [HttpGet]
        [Route("/items/update/{id:int}")]
        public IActionResult update(int id)
        {
            User user = (User) this._items.GetById(id);
            return View(new UpdateViewModels(user));
        }

        [HttpPost]
        [Route("/items/update")]
        public RedirectResult update(User user)
        {
            user = (User) this._items.SaveOne(user);
            return Redirect("/users/update/" + user.id);
        }

        [HttpPost]
        [Route("/items/delete/{id:int}")]
        public ActionResult delete(int id)
        {
            _items.RemoveById(id);
            return Redirect("/users/index");
        }
    }
}