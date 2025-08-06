using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class Catagory
    {
        [Key]
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
    }
}