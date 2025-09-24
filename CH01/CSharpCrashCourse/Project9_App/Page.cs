using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_App
{
   
    internal class Page : ITurnable
    {
        private static int _instanceCount = 0;
        public Page() {
            _instanceCount++;
        }
        public int GetCount()
        {
            return _instanceCount;
        }
        public string Turn()
        {
            return "It's time to turn the page buddy.";
        }
    }
}
