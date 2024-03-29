﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Some_Inharitanse_Samples.BasicSamples.Internal
{
    internal class Foo
    {
        internal string Name { get; set; }
        internal int Age { get; set; }
        internal virtual int CheckAge() => Age;
    }
    internal class FooHeir : Foo
    {
        internal override int CheckAge()
        {
            return base.CheckAge();
        }

        public string AccessCheck()
        {
            return "Можливий доступ, як до полів, так і до функцій";
        }
    }
    public class internalSample1
    {
        public void AccessCheck()
        {
            Foo foo = new Foo();
            FooHeir heir = new FooHeir();
            foo.Age = 1;
            foo.CheckAge();
            heir.Age = 2;
            heir.CheckAge();
            Console.WriteLine("До всіх полів є доступ в середині збірки");
        }
    }
}
