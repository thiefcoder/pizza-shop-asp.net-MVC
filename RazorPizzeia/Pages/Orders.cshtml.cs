using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeia.Data;
using RazorPizzeia.Models;

namespace RazorPizzeia.Pages
{
    public class OrdersModel : PageModel
    {
        public List<pizzaOrder> PizzaOrders = new List<pizzaOrder>();
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
