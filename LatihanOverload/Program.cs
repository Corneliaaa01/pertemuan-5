using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            numbers.CariNilaiMin(20, 30);
            numbers.CariNilaiMax(95, 35, 50);
        }
    }
}



