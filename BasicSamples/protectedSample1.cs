using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Inharitanse_Samples.BasicSamples.Protected
{
    internal class Foo
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected virtual int CheckAge() => Age;
    }
    internal class FooHeir : Foo
    {
        protected override int CheckAge()
        {
            return base.CheckAge();
        }

        public string AccessCheck()
        {
            return "Можливий доступ, як до полів, так і до функцій";
        }
    }

    internal class protectedSample1
    {
        public static void AccessCheck()
        {
            FooHeir heir = new FooHeir();
            Console.WriteLine("Неможливий доступ ні до полів ні до функцій.");
        }
    }
}
