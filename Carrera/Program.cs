using System;
using System.Threading;

namespace ConsoleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando carrera...");

            // Crear dos corredores
            Corredor corredor1 = new Corredor(1, ConsoleColor.Red);
            Corredor corredor2 = new Corredor(2, ConsoleColor.Green);

            // Iniciar los threads de los corredores
            Thread hilo1 = new Thread(new ThreadStart(corredor1.Corre));
            Thread hilo2 = new Thread(new ThreadStart(corredor2.Corre));
            hilo1.Start();
            hilo2.Start();

            // Esperar a que ambos corredores crucen la meta
            hilo1.Join();
            hilo2.Join();

            Console.WriteLine("Fin de la carrera!");
            Console.ReadKey();
        }
    }

    class Corredor
    {
        private int id;
        private ConsoleColor color;
        private int posicion;

        public Corredor(int id, ConsoleColor color)
        {
            this.id = id;
            this.color = color;
            this.posicion = 0;
        }

        public void Corre()
        {
            while (posicion < 20)
            {
                // Generar un número aleatorio para la cantidad de pasos del corredor
                Random rand = new Random();
                int pasos = rand.Next(1, 4);

                // Mover el corredor hacia adelante
                posicion += pasos;

                // Imprimir la posición del corredor en la pantalla
                Console.SetCursorPosition(id * 5, posicion);
                Console.ForegroundColor = color;
                Console.Write("*");

                // Esperar un momento antes de continuar
                Thread.Sleep(100);
            }

            Console.SetCursorPosition(id * 5, 20);
            Console.ForegroundColor = color;
            Console.Write("FIN");
        }
    }
}