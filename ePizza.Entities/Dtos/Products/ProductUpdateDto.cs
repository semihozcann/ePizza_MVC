﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Entities.Dtos.Products
{
    public class ProductUpdateDto
    {

        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please Enter UnitPrice")]
        public decimal UnitPrice { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Please Select Category")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please Select Product Type")]
        public int ProductTypeId { get; set; }

    }
}
