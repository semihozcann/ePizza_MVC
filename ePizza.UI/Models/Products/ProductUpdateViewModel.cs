﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ePizza.UI.Models.Products
{
    public class ProductUpdateViewModel : BaseViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "İsim kısmı boş olamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Açıklama kısmı boş olamaz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Fiyat kısmı boş olamaz")]
        public decimal UnitPrice { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen ürün kategorisi seçiniz")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Lütfen ürün tipini seçiniz")]
        public int ProductTypeId { get; set; }



        public List<SelectListItem> CategoriesForDr { get; set; }
        public List<SelectListItem> ProductTypesForDr { get; set; }
    }
}
