using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_App
{
    internal class Pancake : ITurnable
    {
        private static int _instanceCount = 0;
        public Pancake()
        {
            _instanceCount++;
        }
        public int GetCount()
        {
            return _instanceCount;
        }
        public string Turn()
        {
            return "I turn flat on my belly for a delicious breakfast!";
        }
    }
}
