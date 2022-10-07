using System;

namespace Numero4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bienvenida
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("$$Bienvenido al sistema de cambio monetario$$");
            Console.WriteLine("$-Presiona cualquier tecla para continuar-$$$");
            Console.ReadKey();
            //Llamo a la funcion
            cambio();
            //Despedida
            Console.Clear();
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Gracias por utilizar mi sistema :)");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
        //Funcion con while para repetir las veces requeridas y switch para el menu
        static void cambio(){
            //variables e inicializacion
            double pesos,dolares,euros,cuantos;
            pesos=1d;
            dolares=149d;
            euros=146d;
            cuantos=0;
            String eleccion="A";
            //while
            while(eleccion!="s" && eleccion!="S"){
            Console.WriteLine("Para calcular euros presione (E), para calcular dolares presione (D), para salir presione (S)");
            eleccion=Console.ReadLine();
            //switch menu
            switch(eleccion)
            {
                case "e"or"E":
                Console.Clear();
                Console.WriteLine("Cuantos euros desea calcular?");
                cuantos=Convert.ToDouble(Console.ReadLine());
                cuantos=(cuantos*euros);
                Console.WriteLine("El monto en pesos seria "+(cuantos*pesos)+" pesos");
                break;
                case "d"or"D":
                Console.Clear();
                Console.WriteLine("Cuantos dolares desea calcular?");
                cuantos=Convert.ToDouble(Console.ReadLine());
                cuantos=(cuantos*dolares);
                Console.WriteLine("El monto en pesos seria "+(cuantos*pesos)+" pesos");
                break;
                default:
                Console.Clear();
                Console.WriteLine("Error! Ingrese las letras correctas");
                break;
            }
            }
            return;
        }
    }
}
