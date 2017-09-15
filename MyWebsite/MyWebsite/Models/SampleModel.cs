using System.ComponentModel.DataAnnotations;

namespace MyWebsite.Models
{
    public class SampleModel
    {
        [Display(Name = "Hello")]
        public string Content { get; set; }
    }
}