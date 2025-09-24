using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9
{
    internal class Patient : IRecoverable
    {
        public string Recover()
        {
            return "Patient recovering in doctor's office";
        }
    }
}
