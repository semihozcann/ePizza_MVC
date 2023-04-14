using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Entities.Dtos.Products
{
    public class ProductAddDto
    {
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

    }
}
