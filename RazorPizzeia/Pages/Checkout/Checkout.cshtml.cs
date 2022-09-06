using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeia.Data;
using RazorPizzeia.Models;

namespace RazorPizzeia.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]

    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }

        public float PizzaPrice { get; set; }

        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            pizzaOrder pizzaOrder = new pizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }
}
