using System;
using System.Collections.Generic;
using System.Text;

namespace Warm_up_loops
{
    public class Reverser
    {
        //string toReverse = "hello";
        public string Reverse(string toReverse)
        {
            char[] charArray = toReverse.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray); 
        }
    }
}
