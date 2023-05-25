using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11D_Nikolay_Lalov_ORM__KidsShop_.Back_end.Model
{
  public class Product_Types
    {
        public int Number_of_product { get; set; }          // ID //
        public string Name_of_clothes { get; set; }      // Name //


        //  1:Many  //

        public ICollection<Products> ProductsS { get; set; }

    }
}
