using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathConsoleApp
{
    public class MyMath2
    {
        // checked keyword detects overflow
        // when answer is out of bounds for byte range
        public static byte Add(byte myByte1, byte myByte2)
        {
            checked 
            {
                byte addMethodReturn = (byte)(myByte1 + myByte2);
                return addMethodReturn;
            }
            
        }
    }
}
