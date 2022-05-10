using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class DelegateSample
    {
        public delegate int Operation(int x, int y);

       public static int Addition(int a, int b)
        {
            return a + b;
        }
      public  static int Addition123(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
