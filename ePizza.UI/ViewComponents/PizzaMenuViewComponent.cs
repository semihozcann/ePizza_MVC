using ePizza.Services.Interfaces;
using ePizza.Shared.Utilities.Results.ComplexType;
using Microsoft.AspNetCore.Mvc;

namespace ePizza.UI.ViewComponents
{
    public class PizzaMenuViewComponent: ViewComponent
    {
        private readonly IProductService _productService;

        public PizzaMenuViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _productService.GetAllAsync();

            if (result.Result.ResultStatus == ResultStatus.Success)
            {
                return View("~/Views/Shared/_PizzaMenu.cshtml", result.Result.Data);
            }
            else
            {
                return View("~/Views/Shared/_PizzaMenu.cshtml");
            }
        }
    }
}
