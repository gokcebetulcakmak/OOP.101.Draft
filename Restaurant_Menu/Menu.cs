using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Menu
{
    //Restoranın menüsünü tarif eden class
    internal class Menu
    {
        public Menu() //Yapıcı method (constructor)
        { 

        }   
        public int MenuID { get; set; }// Menüdeki ürünün sıra numarası
        public string MenuName { get; set; }
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }
        public int CategoryID { get; set; } //Ürün hangi kategoriye ait

    }
}
