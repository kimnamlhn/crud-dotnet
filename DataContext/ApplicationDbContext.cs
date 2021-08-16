using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using crud_dotnet.Models; 

namespace crud_dotnet.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base(nameOrConnectionString: "MyConnection")
        {

        }

        public virtual DbSet<CustomerClass> CustomerObj { get; set; }
    }
}