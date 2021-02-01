using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategoryShop.Models
{
     public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desription { get; set; }


        //Navigation property
        public IList<Product> Products { get; set; }  //A category has many products.


    }
}
