﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Project
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "The product name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage = "Please enter a product name made up of letters and numbers only")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The product description cannot be blank")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Please enter a product description between 10 and 200 characters in length")]
        [RegularExpression(@"^[,;a-zA-Z0-9'-'\s]*$", ErrorMessage = "Please enter a product description made up of letters and numbers only")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }



        
    }
}