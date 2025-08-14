using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class ToDo
    {
        [Key]
        public int TodoId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Title { get; set; }
        [Column(TypeName = "bit")]

        public bool Status { get; set; }

    }
}