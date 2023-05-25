using _11D_Nikolay_Lalov_ORM__KidsShop_.Back_end.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _11D_Nikolay_Lalov_ORM__KidsShop_.Settings.Controller
{
    public class ProductsContext : DbContext
    {
    public class ProductsContext () : base("")
        public ProductsContext() : base("ProductsContext")
        {

        }
        public DbSet<Products> Products{ get;set;}
        public DbSet<Product_Types> product_typesS { get; set; }
    }
}
