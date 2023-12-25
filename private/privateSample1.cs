using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Inharitanse_Samples.Private
{
    internal class Foo
    {
        private string Name {  get; set; }
        private int Age { get; set; }
        private int CheckAge() => Age;
    }
    internal class FooHeir : Foo
    {

    }

    public class privateSample1
    {

    }
}
