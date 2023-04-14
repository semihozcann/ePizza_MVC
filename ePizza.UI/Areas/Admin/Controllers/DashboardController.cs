using ePizza.Repositories.Models;
using ePizza.Services.Interfaces;
using ePizza.UI.Interfaces;
using ePizza.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ePizza.UI.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly IOrderService _orderService;
        private readonly ICategoryService _categoryService;
        private readonly IProductTypeService _productTypeService;
        private readonly IProductService _productService;



        public DashboardController(IUserAccessor userAccessor, IOrderService orderService, ICategoryService categoryService, IProductTypeService productTypeService, IProductService productService) : base(userAccessor)
        {
            _orderService = orderService;
            _categoryService = categoryService;
            _productTypeService = productTypeService;
            _productService = productService;
        }


        public async Task<IActionResult> Index(AdminDashboardViewModel adminDashboardViewModel)
        {
            var category = await _categoryService.GetAllAsync();
            var productType = await _productTypeService.GetAllAsync();
            var product = await _productService.GetAllAsync();

            var model = new AdminDashboardViewModel
            {
                CategoryCount = category.Data.Categories.Count,
                ProductTypeCount = productType.Data.ProductTypes.Count,
                ProductCount = product.Data.Products.Count,
            };

            return View(model);
        }

        public IActionResult Details(string orderId)
        {
            OrderModel order = _orderService.GetOrderDetails(orderId);
            return View(order);
        }
    }
}
