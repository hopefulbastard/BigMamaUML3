using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BigMamaUML3;

namespace BigMamaUML3Test
{
    [TestClass]
    public class MenuCatalogTestProject
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            IMenuCatalog menuCatalog = new MenuCatalog();
            Pizza p1 = new Pizza(1, "Margherita", "Tomato and cheese", 69, MenuType.Pizza, false, true, false);
            Pizza p2 = new Pizza(2, "Vesuvio", "Tomato, cheese and ham", 75, MenuType.Pizza, false, false, false);

            //Act
            int beforeAdd = menuCatalog.Count;
            menuCatalog.Add(p1);
            menuCatalog.Add(p2);
            int afterAdd = menuCatalog.Count;


            //Assert
            Assert.AreEqual(beforeAdd + 2, afterAdd);
        }

        [TestMethod]
        public void TestDelete()
        {
            //Arrange
            IMenuCatalog menuCatalog = new MenuCatalog();
            Pizza p1 = new Pizza(1, "Margherita", "Tomato and cheese", 69, MenuType.Pizza, false, true, false);
            Pizza p2 = new Pizza(2, "Vesuvio", "Tomato, cheese and ham", 75, MenuType.Pizza, false, false, false);
            Pizza p3 = new Pizza(3, "Cappricciosa", "Tomato, cheese, ham and mushrooms", 80, MenuType.Pizza, false, false, true);
            menuCatalog.Add(p1);
            menuCatalog.Add(p2);
            menuCatalog.Add(p3);

            //Act
            int beforeDelete = menuCatalog.Count;
            menuCatalog.Delete(1);
            menuCatalog.Delete(2);
            int afterDelete = menuCatalog.Count;

            //Assert
            Assert.AreEqual(beforeDelete - 2, afterDelete);

        }

        [TestMethod]
        public void TestUpdate()
        {

            //Arrange
            IMenuCatalog menuCatalog = new MenuCatalog();
            Pizza pizza = new Pizza(1, "Margherita", "Tomato and cheese", 69, MenuType.Pizza, false, true, false);
            Pizza updatePizza = new Pizza(1, "Vesuvio", "Tomato, cheese and ham", 75, MenuType.Pizza, false, false, false);
            menuCatalog.Add(pizza);

            //Act
            if (menuCatalog.Search(1).Name != updatePizza.Name)
            {
                menuCatalog.Update(1, updatePizza);
            }
            else
            {
                Assert.Fail();
            }

            //Assert
            Assert.AreEqual(menuCatalog.Search(1).Name, updatePizza.Name);
        }

    }
}