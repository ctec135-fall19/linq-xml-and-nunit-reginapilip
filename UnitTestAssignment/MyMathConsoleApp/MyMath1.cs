using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathConsoleApp
{
    public class MyMath1
    {
        // add a static method to MyMath1 named Add. It should take two byte type 
        // arguments and return a byte type value.
        public static byte Add(byte myByte1, byte myByte2)
        {
                byte addMethodReturn = (byte)(myByte1 + myByte2);
                return addMethodReturn;
        }
    }
}
