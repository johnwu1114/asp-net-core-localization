using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.Models
{
    public class SampleModel
    {
        [Display(Name = "Hello")]
        public string Content { get; set; }
    }
}
