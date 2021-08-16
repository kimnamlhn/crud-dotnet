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

        [Required(ErrorMessage = "The customer name is required")]
        public string customername { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        [Required(ErrorMessage = "The salary is required")]
        public int salary { get; set; }
    }
}