using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_OOP_3_02.Static
{
    internal static class Counter // all members must be static
    {
        public static int _counter = 0 ;

        public static void Increment() => _counter++;

        public static void Decrement() => _counter--;


    }
}
