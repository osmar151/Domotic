using System;


namespace Domotica
{
    class Program
    {
        static Casa app = new Casa();
        static Menu m = new Menu();
        static void Main(string[] args)
        {
            int opciones = 0;

            //integrantes: Giuliana, Lineli, Isabel, Osmar y Fatima"
            //Link de programa de tinkercad: https://www.tinkercad.com/things/g22j7ceScJw-shiny-amur-luulia/editel?sharecode=lhL1BIAEkBAdHA1R1NFs-FRMDWA3uf6n9mpcXctal4k

            while (opciones != 6)

            {

                opciones = m.ListaMenu();

                if (opciones == 1)

                {
                    app.EnviarCaracter("q");
                    Console.WriteLine(" ingrese: 'q' para encender la luz de la sala");

                    Console.WriteLine(" ingrese: 'w' para apagar la luz de la sala");
                    app.EnviarCaracter("w");
                }

                else if (opciones == 2)

                {
                    app.EnviarCaracter("e");
                    Console.WriteLine(" ingrese: 'e' para encender el televisor");

                    Console.WriteLine(" ingrese: 'r' para apagar el televisor");
                    app.EnviarCaracter("r");

                }

                else if (opciones == 3)

                {
                    app.EnviarCaracter("t");
                    Console.WriteLine(" ingrese: 't' para abrir el garage");

                    app.EnviarCaracter("y");
                    Console.WriteLine(" ingrese: 'y' para abrir a la mitad el garage");

                    Console.WriteLine(" ingrese: 'u' para cerrar el garage");
                    app.EnviarCaracter("u");
                }

                else if (opciones == 4)

                {
                    app.EnviarCaracter("a");
                    Console.WriteLine(" ingrese: 'a' para abrir la cortina 1");

                    Console.WriteLine(" ingrese: 'b' para cerrar la cortina 1");
                    app.EnviarCaracter("b");
                }

                else if (opciones == 5)

                {

                    app.EnviarCaracter("c");
                    Console.WriteLine(" ingrese: 'c' para abrir la cortina 2");

                    Console.WriteLine(" ingrese: 'd' para cerrar la cortina 2");
                    app.EnviarCaracter("d");

                }

                else if (opciones == 6)

                {
                    app.EnviarCaracter("i");
                    Console.WriteLine(" ingrese: 'i' para la intensidad 1 de la luz del estudio");

                    app.EnviarCaracter("o");
                    Console.WriteLine(" ingrese: 'o' para la intensidad 2 de la luz del estudio");

                    app.EnviarCaracter("p");
                    Console.WriteLine(" ingrese: 'p' para la intensidad 3 de la luz del estudio");

                    app.EnviarCaracter("a");
                    Console.WriteLine(" ingrese: 'a' para la intensidad 4 de la luz del estudio");

                    app.EnviarCaracter("s");
                    Console.WriteLine(" ingrese: 's' para la intensidad 5 de la luz del estudio");

                    Console.WriteLine(" ingrese: 'h' para apagar la luz del estudio");
                    app.EnviarCaracter("h");
                }

            }

            Console.ReadKey();
        }
    }
}
        


    



