﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Inharitanse_Samples.ComplexSamples.Sample1
{
    interface I
    {
        internal void func();
    }
    class A : I
    {
        void I.func()
        {
            Console.WriteLine("A Class");
        }
    }
    class B : A
    {
        void func()
        {
            Console.WriteLine("BClass");
        }
    }

    internal class Sample1
    {
        public static void SampleMain()
        {
            I Aclass = new A();
            I Bclass = new B();
            Aclass.func();
            Bclass.func();
        }
    }
}
