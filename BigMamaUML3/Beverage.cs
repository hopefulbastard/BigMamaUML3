using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamaUML3
{
    public class Beverage : MenuItem
    {
        private bool _alcohol;
        private bool _isSugarfree;

        public bool Alcohol
        {
            get; set;
        }

        public bool IsSugarfree
        {
            get; set;
        }

        public Beverage(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool alcohol, bool isSugarfree) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            Alcohol = alcohol;
            IsSugarfree = isSugarfree;
        }

        public override string PrintInfo()
        {
            return base.PrintInfo() + $"\nAlcohol: {Alcohol} \nSugarfree: {IsSugarfree}";
        }

    }
}
