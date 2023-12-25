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
        private int Age { get; set; }
        public string AccessCheck()
        {
            return "Неможливо отримати доступ до приватних полів батьківського класу, ні оверрайднути функцію, але можна створити Нові поля з тими ж назвами";
        }
    }

    public class privateSample1
    {
        public static void MakeChecks()
        {
            Foo foo = new Foo();
            FooHeir foo1 = new FooHeir();
            Console.WriteLine($"Неможливо отримати доступ ні до приватних полів, ні до наслідуваних приватних полів, з зовнішнього классу, висновок з внутрішнього класу наступний:\n {foo1.AccessCheck}");
        }
    }
}
