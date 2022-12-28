using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Menu
{
    internal class Category
    {
        public Category()
        {//ctor

        }
        //clasımızın eleman özelliklerini - property - alanlarını tanımlıyorum.Yani yapıyı tanımlıyorum.
        public int CategoryID { get; set; }//Sistemimdeki her kategorinin bir değeri var
        public string  CategoryName{ get; set; } // Sistemimdeki her kategorinin bir de ismi var.

    }
}
