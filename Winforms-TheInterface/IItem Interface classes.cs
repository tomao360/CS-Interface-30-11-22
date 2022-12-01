using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_TheInterface
{
    internal class Cola : IItem
    {
        public int GetPrice()
        {
            return 10;
        }

        public string GetName()
        {
            return "Cola";
        }
    }

    internal class Kinley : IItem
    {
        public int GetPrice()
        {
            return 11;
        }

        public string GetName()
        {
            return "Kinley";
        }
    }
}
