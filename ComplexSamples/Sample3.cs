using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Inharitanse_Samples.ComplexSamples.Sample3
{
    internal interface I
    {
        public void func();
    }
    internal abstract class A : I
    {
        public virtual void func()
        {
            Console.WriteLine("AClass");
        }
    }
    internal class B : A
    {
        public void func()
        {
            Console.WriteLine("BClass");
        }
    }
    internal class C : I
    {
        public void func()
        {
            Console.WriteLine("CClass");
        }
    }
    internal class Sample3
    {
        public static void SampleMain()
        {
            I bclass = new B();
            I cclass = new C();
            bclass.func();
            cclass.func();
        }
    }
}
