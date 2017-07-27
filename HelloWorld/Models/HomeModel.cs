using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class HomeModel
    {
        [Display(Name = "Message Text")]
        [DataType("string")]
        public string Message { get; set; }
    }
}