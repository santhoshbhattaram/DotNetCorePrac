﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCorePrac.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int  Name{ get; set; }
        public int DisplayOrder { get; set; }
    }
}
