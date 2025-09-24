using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_App
{
    internal class Corner : ITurnable
    {
        private static int _instanceCount = 0;
        public Corner()
        {
            _instanceCount++;
        }
        public int GetCount()
        {
            return _instanceCount;
        }
        public string Turn()
        {
            return "You can turn the corner all right pal :)";
        }
    }
}
