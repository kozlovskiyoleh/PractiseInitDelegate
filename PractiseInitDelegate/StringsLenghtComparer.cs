using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseInitDelegate
{
    public class StringsLenghtComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if(x == null || y == null)
                throw new ArgumentNullException();
            return x.Length.CompareTo(y.Length);
        }
    }

    public class StringsComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();
            return x.CompareTo(y);
        }
    }
}
