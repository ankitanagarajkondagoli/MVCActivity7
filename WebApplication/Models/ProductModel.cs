using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ProductModel
    {
        [Required(ErrorMessage = "Product Name shouldn't be Empty"), MaxLength(50)]
        [Display(Name = "ProductName")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "ProductName can hold only Alphabets")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "ProductGroupName")]
        public string ProductGroupName { get; set; }
    }
}