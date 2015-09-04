using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Globalization.Models
{
    public class Demo
    {
        [DisplayName("Name")]
        [Required(ErrorMessage="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage="Age is required")]
        public int Age { get; set; }
    }
}