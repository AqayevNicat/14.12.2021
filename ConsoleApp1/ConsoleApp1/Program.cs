using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator clc = new Calculator();
            clc.Toplama(4, 2);
            clc.Cixma(4, 2);
            clc.Vurma(4, 2);
            clc.Bolme(4, 2);
        }
    }
}
