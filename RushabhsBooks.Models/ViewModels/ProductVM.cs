using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace RushabhsBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }    //Display all the product details
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}