using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamaUML3
{
    public class MenuItemNumberExists : Exception
    {
        public MenuItemNumberExists(string message) : base(message)
        {

        }
    }
}
