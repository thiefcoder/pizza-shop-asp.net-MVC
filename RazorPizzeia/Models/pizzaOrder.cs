using System.ComponentModel.DataAnnotations;

namespace RazorPizzeia.Models
{
    public class pizzaOrder
    {
        [Key]
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; }
    }
}
