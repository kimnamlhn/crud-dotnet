using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace crud_dotnet.Models
{
    [Table("customer", Schema = "public")]
    public class CustomerClass
    {
        [Key]
        public int customerid { get; set; }
        public string customername { get; set; }
        public string email { get; set; }
        public int salary { get; set; }
    }
}