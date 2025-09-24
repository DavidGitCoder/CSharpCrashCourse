using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{
    internal class Book
    {

        //private int _numPages;

        ////C# Properties - THE OLD WAY
        //public int NumPages
        //{
        //    get { return _numPages; }
        //    set { _numPages = value; }
        //}

        //Auto-implemented Property - THE NEW WAY (unless you need to implement more business logic then use the OLD WAY)
        public int? NumPages { get; set; } = 200; //no need to create the _numPages private field

        public override string ToString()
        {
            return $"This book has {NumPages} pages.";
        }

    }
}
