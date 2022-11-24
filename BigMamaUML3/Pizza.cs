using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamaUML3
{

    public class Pizza : MenuItem
    {
        private bool _deepPan;

        public bool DeepPan
        {
            get { return _deepPan; }
            set { _deepPan = value; }
        }

        public Pizza(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool deepPan) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            DeepPan = DeepPan;

        }

        public override string PrintInfo()
        {
            return base.PrintInfo() + $" \nDeep pan: {DeepPan}";
        }
    }
}
