using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_App
{
    internal class Leaf : ITurnable
    {
        private static int _instanceCount = 0;
        public Leaf()
        {
            _instanceCount++;
        }
        public int GetCount()
        {
            return _instanceCount;
        }
        public string Turn()
        {
            return "I turn like a leaf in the wind";
        }
    }
}
