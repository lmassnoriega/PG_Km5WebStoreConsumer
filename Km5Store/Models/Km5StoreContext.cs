using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Km5Store.Models
{
    public class Km5StoreContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Km5StoreContext() : base("name=Km5StoreContext")
        {
        }

		public System.Data.Entity.DbSet<Km5Store.Models.Album> Albums { get; set; }

		public System.Data.Entity.DbSet<Km5Store.Models.Movie> Movies { get; set; }

		public System.Data.Entity.DbSet<Km5Store.Models.Artist> Artists { get; set; }
	}
}
