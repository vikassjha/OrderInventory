using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using OrderInventory.Data;
using OrderInventory.Models;
using System.Collections;

namespace OrderInventory.Controllers
{
    public class OrderController : Controller
    {
        public object ViewBag { get; }
        private readonly CoreDBContext context;
        public OrderController(CoreDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var orders = context.Orders.ToList();
            return View(orders);
        }
        [HttpGet]
        public IActionResult ItemList(int Id) {
           
            var OdList = context.OrderItems.Where(o => o.OrderId == Id).Select(o => new OrderDetails
            { ItemId =o.Item.ItemId, ItemName=o.Item.ItemName, Id=o.Id });           
           
            var result = OdList.ToList();
           


            return View(result);
        
        }

        [HttpGet]
        public IActionResult OrderDetails(int Id)
        {

            var price = context.OrderItems.FirstOrDefault(x => x.Id == Id);

            



            return View(price);

        }



    }
}
