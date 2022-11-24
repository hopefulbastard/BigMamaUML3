using BigMamaUML3;

namespace BigMamaUML3
{

    public class Program
    {
        public static void Main(string[] arcs)
        {
            //step 2: add menu items
            /*MenuCatalog menuCatalog = new MenuCatalog();

            Pizza p1 = new Pizza(1, "Margherita", "Tomato and cheese", 69, MenuType.Pizza, false, true, false);
            Pizza p2 = new Pizza(2, "Vesuvio", "Tomato, cheese and ham", 75, MenuType.Pizza, false, false, false);
            Pizza p3 = new Pizza(3, "Cappricciosa", "Tomato, cheese, ham and mushrooms", 80, MenuType.Pizza, false, false, true);

            Console.WriteLine($"Menucatalog count before Add function: {menuCatalog.Count}");

            menuCatalog.Add(p1);
            menuCatalog.Add(p2);
            menuCatalog.Add(p3);

            Console.WriteLine($"Menucatalog count after pizzas have been added: {menuCatalog.Count}");

            Beverage b1 = new Beverage(4, "Coca Cola", "Cola with sugar", 30, MenuType.Drink, true, false, false, false);
            Beverage b2 = new Beverage(5, "Coca Cola Zero", "Cola without sugar", 30, MenuType.Drink, true, false, false, true);
            Beverage b3 = new Beverage(6, "Fanta Exotic", "Fanta Exotic with sugar", 30, MenuType.Drink, true, false, false, false);


                menuCatalog.Add(b1);
                menuCatalog.Add(b2);
                menuCatalog.Add(b3);


            Console.WriteLine($"Menucatalog count after drinks have been added: {menuCatalog.Count}");

            //step 3: test other functions

            Console.WriteLine($"\nTest of Delete function. Amount of menu items before test: {menuCatalog.Count}");
            menuCatalog.Delete(3);
            Console.WriteLine($"Amount of menu items after test: {menuCatalog.Count}");

            Console.WriteLine("\nTest of PrintPizzaMenu function:");
            menuCatalog.PrintPizzasMenu();

            Console.WriteLine("\nTest of PrintBeveragesMenu function:");
            menuCatalog.PrintBeveragesMenu();

            Console.WriteLine("\nTest of Update function:");
            Console.WriteLine("Pizza before update:");
            menuCatalog.Search(2);
            Pizza updatePizza = new Pizza(2, "Cappricciosa", "Tomato, cheese, ham and mushrooms", 80, MenuType.Pizza, false, false, true);
            menuCatalog.Update(2, updatePizza);
            Console.WriteLine("\nPizza after update:");
            menuCatalog.Search(2);

            Console.WriteLine("\nTest of FindAllVegan function:");
            Console.WriteLine("All vegan drinks:");
            menuCatalog.FindAllVegan(MenuType.Drink);

            Console.WriteLine("\nTest of FindAllOrganic function:");
            Console.WriteLine("All organic pizzas:");
            menuCatalog.FindAllOrganic(MenuType.Pizza);

            Console.WriteLine("\nTest of MostExpensiveMenuItem function:");
            menuCatalog.MostExpensiveMenuItem();

            //step 4: exceptions
            Console.WriteLine($"\nException for menu item with an already existing number:");

            try
            {
                menuCatalog.Add(p2);
            }
            catch (MenuItemNumberExists err)
            {
                Console.WriteLine(err.Message);
            }*/
        }
    }
}
