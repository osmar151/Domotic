using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotica
{
    class Menu
    {
        private int op = 0;

        public int ListaMenu()
        {

            Console.WriteLine("1.- controlar luz de sala ");
            Console.WriteLine("2.- controlar el televisor ");
            Console.WriteLine("3.- controlar el garage ");
            Console.WriteLine("4.- controlar cortina 1 ");
            Console.WriteLine("5.- controlar cortina 2 ");
            Console.WriteLine("6.- controlar luz estudio ");
            Console.WriteLine("7.- salir");
           
            Console.Write("Opcion: ");

            op = int.Parse(Console.ReadLine());

            return op;

        }

    }
}

