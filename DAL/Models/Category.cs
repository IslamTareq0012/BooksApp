﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        [DisplayName("Display Order")]
        public string DisplayOrder { get; set; }
    }
}
