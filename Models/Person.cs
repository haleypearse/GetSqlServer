using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetSqlServer.Models
{
    public class Person
    {
        [Key]
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }
        [Display(Name = "Times Met")]
        public int TimesMet { get; set; }
        [Display(Name = "When Met")]

        public Nullable<DateTime> WhenMet { get; set; }
        [Display(Name = "Last Met")]

        public Nullable<DateTime> LastMet { get; set; }
    }
}