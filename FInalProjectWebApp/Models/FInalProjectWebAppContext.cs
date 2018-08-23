using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FInalProjectWebApp.Models
{
    public class FInalProjectWebAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FInalProjectWebAppContext() : base("name=FInalProjectWebAppContext")
        {
        }

        public System.Data.Entity.DbSet<FInalProjectWebApp.Models.Members> Members { get; set; }

        public System.Data.Entity.DbSet<FInalProjectWebApp.Models.Skills> Skills { get; set; }

        public System.Data.Entity.DbSet<FInalProjectWebApp.Models.Game> Games { get; set; }
    }
}
