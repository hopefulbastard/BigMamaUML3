using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigMamaUML3;
using static BigMamaUML3.MenuItem;

namespace BigMamaUML3
{
    public class MenuCatalog : IMenuCatalog
    {

        List<IMenuItem> _menuItemList;

        public MenuCatalog()
        {
            _menuItemList = new List<IMenuItem>();
        }

        public int Count
        {
            get { return _menuItemList.Count; }
        }

        public void Add(IMenuItem aMenuItem)
        {
            if (Search(aMenuItem.Number) != null)
            {
                throw new MenuItemNumberExists("A menu item with this number already exists.");
            }
            _menuItemList.Add(aMenuItem);
            
        }

        public IMenuItem Search(int number)
        {

            foreach (MenuItem item in _menuItemList)
            {
                if (number == item.Number)
                {
                    Console.WriteLine(item.PrintInfo());
                    return item;
                }
            }
            return null;
        }

        public void Delete(int number)
        {
            foreach (MenuItem item in _menuItemList.ToList())
            {
                if (item.Number == number)
                {
                    Console.WriteLine($"The {item.Type} {item.Name} has been deleted.");
                    _menuItemList.Remove(item);
                }
            }
        }

        public void PrintPizzasMenu()
        {
            foreach (MenuItem item in _menuItemList)
                if (item.Type == MenuType.Pizza)
                {
                    Console.WriteLine(item.PrintInfo());
                }
        }

        public void PrintBeveragesMenu()
        {
            foreach (MenuItem item in _menuItemList)
                if (item.Type == MenuType.Drink)
                {
                    Console.WriteLine(item.PrintInfo());
                }
        }

        public void PrintToppingsMenu()
        {
            throw new NotImplementedException();
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            for(int i = 0; i < _menuItemList.Count; i++)
            {
                if (_menuItemList[i].Number == number)
                {
                    _menuItemList[i] = theMenuItem;
                    Console.WriteLine("\nItem has been updated");
                }
            }



        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> veganList = new List<IMenuItem>();
            foreach (MenuItem item in _menuItemList)
            {
                if (item.Type == type && item.IsVegan == true)
                {
                    veganList.Add(item);
                }
            }
            
            foreach (MenuItem item in veganList)
            {
                Console.WriteLine(item.PrintInfo());
            }
            return null;
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> organicList = new List<IMenuItem>();
            foreach (MenuItem item in _menuItemList)
            {
                if (item.Type == type && item.IsOrganic == true)
                {
                    organicList.Add(item);
                }
            }

            foreach (MenuItem item in organicList)
            {
                Console.WriteLine(item.PrintInfo());
            }
            return null;
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem MostExpensive = _menuItemList[0];

            foreach (MenuItem item in _menuItemList)
            {
                if (MostExpensive.Price < item.Price)
                {
                    MostExpensive = item;
                }
            }

            Console.WriteLine(MostExpensive.PrintInfo());
            return MostExpensive;
        }
    }
}
