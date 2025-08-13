using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class Detail
    {
        [Key]
        public int DetailID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string productname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string productinfo { get; set; }

        public string productlonginfo { get; set; }
    }
}