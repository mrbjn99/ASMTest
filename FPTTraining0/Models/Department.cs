﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FPTTraining0.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Department Name")]
        public string Name { get; set; }
    }
}