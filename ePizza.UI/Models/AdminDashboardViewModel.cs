using ePizza.Entities.Dtos.Categories;
using ePizza.Entities.Dtos.Products;
using ePizza.Entities.Dtos.ProductTypes;

namespace ePizza.UI.Models
{
    public class AdminDashboardViewModel
    {
        public int? CategoryCount { get; set; }
        public int? ProductTypeCount { get; set; }
        public int? ProductCount { get; set; }



    }
}
