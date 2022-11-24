using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigMamaUML3;

namespace BigMamaUML3
{

    public abstract class MenuItem : IMenuItem
    {
        private int _number;
        private string _name;
        private string _description;
        private double _price;
        private MenuType _type;
        private bool _isVegan;
        private bool _isOrganic;

        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }

        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = type;
            IsVegan = isVegan;
            IsOrganic = isOrganic;
        }

        public virtual string PrintInfo()
        {
            return $"\n{Type}\nNumber: {Number}\nName: {Name}\nDescription: {Description}\nPrice: {Price}\nVegan: {IsVegan}\nOrganic: {IsOrganic}";
        }
    }
}
