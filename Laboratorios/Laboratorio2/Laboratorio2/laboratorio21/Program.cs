using System;

namespace laboratorio21
{

    public class Program
    {
        public static void Main()
        {
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);
        }
    }
    public class MyClass
    {
        public static int Valor;
    }
}

