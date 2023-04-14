using ePizza.Entities.Dtos.Categories;
using ePizza.Services.Interfaces;
using ePizza.Shared.Utilities.Results.ComplexType;
using ePizza.UI.Interfaces;
using ePizza.UI.Models.Categories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ePizza.UI.Areas.Admin.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(IUserAccessor userAccessor, ICategoryService categoryService) : base(userAccessor)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _categoryService.GetAllAsync();

            var categories = new CategoryListViewModel
            {
                CategoryListDto = result.Data,
                Message = result.Message
            };
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(categories);
            }
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddViewModel categoryAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var category = new CategoryAddDto
                {
                    Name = categoryAddViewModel.Name,
                    Description = categoryAddViewModel.Description
                };
                var result = await _categoryService.AddAsync(category);
                categoryAddViewModel.Message = result.Message;

                if (result.ResultStatus == ResultStatus.Success)
                {
                    ViewBag.CategoryResultMessage = result.Message;
                    return RedirectToAction("GetAllCategories");
                }
                ViewBag.CategoryResultMessage = result.Message;
                return View(categoryAddViewModel);
            }
            return View(categoryAddViewModel);
        }

        public async Task<IActionResult> Update(int Id)
        {
            var category = await _categoryService.GetAsync(Id);

            var oldCategory = new CategoryUpdateViewModel
            {
                Id = category.Data.Category.Id,
                Name = category.Data.Category.Name,
                Description = category.Data.Category.Description,
                Message = category.Message
            };
            return View(oldCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateViewModel categoryUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var updatedCategory = new CategoryUpdateDto
                {
                    Id = categoryUpdateViewModel.Id,
                    Name = categoryUpdateViewModel.Name,
                    Description = categoryUpdateViewModel.Description
                };

                var result = await _categoryService.UpdateAsync(updatedCategory);
                categoryUpdateViewModel.Message = result.Message;

                if (result.ResultStatus == ResultStatus.Success)
                {
                    ViewBag.CategoryResultMessage = result.Message;
                    return RedirectToAction("GetAllCategories");
                }
                ViewBag.CategoryResultMessage = result.Message;
                return View(updatedCategory);
            }
            return View();

        }


        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _categoryService.DeleteAsync(Id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return RedirectToAction("GetAllCategories");
            }
            return View();
        }







    }
}
