using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_4
{
    internal class Superficiefrontal
    {
        static void Main(string[] args)

        {
            double Base, Altura, Area;
            Console.Write("ingrese la Base:");
            Base = double.Parse(Console.ReadLine());
                 Console.Write("ingrese la Altura:");
            Altura = double.Parse(Console.ReadLine());
                Area = Base * Altura
                Console.writeline("el area es:{0}", Area );
            Console.ReadLine();

        }

    }
}
