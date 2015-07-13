using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwiftyNames.V1._0.Models
{
    public class NewsPaperModel
    {
        public int Id { get; set; }
        public string NewsPaper { get; set; }
        public string Price { get; set; }
        public MultiSelectList NewsPapers{ get; set; }
        public MultiSelectList PriceList { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Delivery Address")]
        public string Address { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Phone  Number")]
        public string phoneNumber { get; set; }
    }
}