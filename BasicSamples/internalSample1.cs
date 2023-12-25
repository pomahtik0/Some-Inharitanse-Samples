using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Inharitanse_Samples.BasicSamples.Internal
{
    internal class Foo
    {
        internal string Name { get; set; }
        internal int Age { get; set; }
        internal int CheckAge() => Age;
    }
    internal class FooHeir : Foo
    {
        public string AccessCheck()
        {
            
        }
    }
    public class internalSample1
    {

    }
}
