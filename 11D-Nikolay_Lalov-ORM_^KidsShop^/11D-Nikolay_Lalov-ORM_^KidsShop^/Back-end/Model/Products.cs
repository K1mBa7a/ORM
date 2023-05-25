using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11D_Nikolay_Lalov_ORM__KidsShop_.Back_end.Model
{
    public class Products
    {
        /// <summary>
        /// This table have boy/girl clothes 
        /// with id's,names,descriptions,prices and sizes !
        /// </summary>
        
       
       
        
       public int Number_of_product { get; set; }                //                     ID's
       public string Name_of_clothes { get; set; }              //                 <<<  Name's  >>>
       public string Description_of_clothes { get; set; }      //              <<<  Description's  >>>
       public int Price_of_clothes { get; set; }              //                  <<<  Price's  >>>
       public int Size_of_clothes { get; set; }              //                   <<<  Size's  >>>
       public string Gender { get;set; }                    //                     <<<  Gender >>>



        ///               Many:1                 ///

        public int Product_TypesID { get; set; }                            //  F_Key  //
        public Product_Types product_typesS { get; set; }                    // Connections //
    }
}
