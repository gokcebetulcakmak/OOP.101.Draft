using System;
using Restaurant_Menu;
internal class Program
{
    private static void Main(string[] args)
    {
        //Kategori
        Category category = new Category(); //sınıf yapısından bir nesne üretiyorum.
        category.CategoryID = 1;
        category.CategoryName = "Çorbalar";

        Console.WriteLine("Kategori Listesi");
        Console.WriteLine("===============\n\n");
        Console.WriteLine(category.CategoryID + ":" + "\t" + category.CategoryName);

        //Menu
        Menu menu = new Menu();
        menu.MenuID = 1;
        menu.MenuName = "P100KY Restaurant Menü ";
        menu.FoodName = "Mercimek Çorbası";
        menu.FoodPrice= 40;
        menu.CategoryID= 1;
        Console.WriteLine(menu.MenuName + "Yemek Listesi");
        Console.WriteLine("===============\n");
        Console.WriteLine(menu.MenuID + ":" + "\t" + menu.FoodName + ": \t" + menu.FoodPrice);

        //Raw
        Raw raw = new Raw();
        raw.RawID = 1;
        raw.RawName = "Mercimek";
        raw.RawAmount = 5; //bir kazan çorba için gerekli malzeme
       
        Console.WriteLine( " Hammadde Listesi");
        Console.WriteLine("===============\n");
        Console.WriteLine(raw.RawID + ":" + "\t" + raw.RawName + ": \t" + raw.RawAmount);

        Console.ReadKey();
    }
}