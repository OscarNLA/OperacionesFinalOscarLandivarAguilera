using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace operaciones.Models
{
    public class numeromodelo
    {
        [Key]
        public int numero { get; set; }
        public string mensaje { get; set; }
    }
}