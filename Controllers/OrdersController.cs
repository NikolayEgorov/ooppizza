using pizza.Models;
using pizza.Interfaces;
using pizza.ViewModels.Orders;
using Microsoft.AspNetCore.Mvc;

namespace pizza.Controllers {
    public class OrdersController : Controller
    {
        private readonly IOrders _iorders;
        private readonly IUsers _iusers;

        public OrdersController(IOrders iOrders, IUsers iUsers)
        {
            this._iorders = iOrders;
            this._iusers = iUsers;
        }

        [Route("/orders/index")]
        public IActionResult index()
        {
            IndexViewModels viewModels = new IndexViewModels(_iorders.All);
            return View(viewModels);
        }

        [Route("/orders/create")]
        public IActionResult create()
        {
            List<User> users = this._iusers.All;
            return View(new UpdateViewModels(new Order(), users));
        }

        [HttpGet]
        [Route("/orders/update/{id:int}")]
        public IActionResult update(int id)
        {
            Order order = this._iorders.GetById(id);
            List<User> users = this._iusers.All;

            return View(new UpdateViewModels(order, users));
        }

        [HttpPost]
        [Route("/orders/update")]
        public RedirectResult update(Order order, List<Item> items)
        {
            int userid = Int32.Parse(Helpers.GetFormData(Request.Form, "userid").Value);

            order.user = this._iusers.GetById(userid);
            order = this._iorders.SaveOne(order);
            // this._iorders.SaveUser(order);

            // foreach (string productId in Helpers.ParseMultipleSelectValue(Request.Form, "products")) {
            //     products.Add(this._iproducts.GetById(Int32.Parse(productId)));
            // }
            // item.products = products;

            return Redirect("/orders/index");
        }

        [HttpPost]
        [Route("/orders/delete/{id:int}")]
        public ActionResult delete(int id)
        {
            this._iorders.RemoveById(id);
            return Redirect("/orders/index");
        }
    }
}