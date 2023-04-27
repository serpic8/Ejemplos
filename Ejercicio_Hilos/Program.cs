using System;
using System.Threading;

/*class Program
{
    static int NUM_CORREDORES = 4;
    static int DISTANCIA = 100;
    static Thread[] corredores = new Thread[NUM_CORREDORES];
    static int[] tramos = new int[NUM_CORREDORES];
    static bool[] testigo = new bool[NUM_CORREDORES];
    static Random rnd = new Random();
    static int ganador;

    static void Main(string[] args)
    {
        Console.WriteLine("Carrera de relevos: {0} corredores, {1} metros de distancia", NUM_CORREDORES, DISTANCIA);
        Console.WriteLine();

        // Inicializar los tramos y el testigo
        for (int i = 0; i < NUM_CORREDORES; i++)
        {
            tramos[i] = i * DISTANCIA / NUM_CORREDORES;
            testigo[i] = false;
        }

        // Crear los corredores
        for (int i = 0; i < NUM_CORREDORES; i++)
        {
            corredores[i] = new Thread(Corredor);
            corredores[i].Start(i);
        }

        // Esperar a que terminen los corredores
        for (int i = 0; i < NUM_CORREDORES; i++)
        {
            corredores[i].Join();
        }

        // Mostrar el resultado de la carrera
        Console.WriteLine("El ganador es el corredor {0}", ganador + 1);
        Console.WriteLine();

        Console.Write("Pulsa una tecla para salir...");
        Console.ReadKey();
    }

    static void Corredor(object id)
    {
        int miId = (int)id;
        int distanciaRecorrida = tramos[miId];

        while (distanciaRecorrida < DISTANCIA)
        {
            // Correr
            int distanciaAvanzada = rnd.Next(5, 15);
            distanciaRecorrida += distanciaAvanzada;
            Console.SetCursorPosition(miId, distanciaRecorrida);
            Console.Write(miId + 1);

            // Pasar el testigo
            if (distanciaRecorrida >= tramos[(miId + 1) % NUM_CORREDORES] && !testigo[(miId + 1) % NUM_CORREDORES])
            {
                testigo[(miId + 1) % NUM_CORREDORES] = true;
                Console.SetCursorPosition(NUM_CORREDORES, tramos[(miId + 1) % NUM_CORREDORES]);
                Console.Write("*");
            }

            // Esperar un poco
            Thread.Sleep(50);
        }

        // Comprobar que el testigo ha sido pasado correctamente
        if (!testigo[(miId + 1) % NUM_CORREDORES])
        {
            Console.SetCursorPosition(NUM_CORREDORES, tramos[miId]);
            Console.Write("!");
        }
        else
        {
            // Actualizar el ganador
            ganador = (miId + 1) % NUM_CORREDORES;
        }
    }
}*/
using System;
using System.Collections.Generic;
using System.Threading;

namespace CarreraDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a la carrera de carros!");

            // Crear los carros de la carrera
            var carros = new List<Carro>();
            carros.Add(new Carro("Ferrari"));
            carros.Add(new Carro("Mercedes"));
            carros.Add(new Carro("Red Bull"));
            carros.Add(new Carro("McLaren"));
            carros.Add(new Carro("Renault"));

            // Iniciar la carrera
            var threads = new List<Thread>();
            foreach (var carro in carros)
            {
                var t = new Thread(() => CarroCarrera(carro));
                threads.Add(t);
                t.Start();
            }

            // Esperar a que todos los carros lleguen a la meta
            foreach (var thread in threads)
            {
                thread.Join();
            }

            // Ordenar los carros por orden de llegada
            carros.Sort((c1, c2) => c1.TiempoDeLlegada.CompareTo(c2.TiempoDeLlegada));

            // Mostrar el resultado de la carrera
            Console.WriteLine("Resultado de la carrera:");
            foreach (var carro in carros)
            {
                Console.WriteLine($"Carro {carro.Nombre} llegó en {carro.TiempoDeLlegada} segundos.");
            }
        }

        static void CarroCarrera(Carro carro)
        {
            var random = new Random();
            while (!carro.LlegoAMeta)
            {
                // Mover el carro hacia adelante en un intervalo de tiempo aleatorio
                var distanciaRecorrida = random.Next(1, 10);
                var tiempoTranscurrido = random.Next(1, 5);
                carro.Avanzar(distanciaRecorrida, tiempoTranscurrido);
                Console.WriteLine($"Carro {carro.Nombre} avanzó {distanciaRecorrida} metros en {tiempoTranscurrido} segundos.");

                // Comprobar si el carro llegó a la meta
                if (carro.Posicion >= 100)
                {
                    carro.LlegoAMeta = true;
                    carro.TiempoDeLlegada = carro.TiempoTotal;
                    Console.WriteLine($"Carro {carro.Nombre} llegó a la meta en {carro.TiempoDeLlegada} segundos.");
                }

                // Esperar un tiempo antes de mover el carro de nuevo
                Thread.Sleep(100);
            }
        }
    }

    class Carro
    {
        public string Nombre { get; }
        public int Posicion { get; private set; }
        public int TiempoTotal { get; private set; }
        public int TiempoDeLlegada { get; set; }
        public bool LlegoAMeta { get; set; }

        public Carro(string nombre)
        {
            Nombre = nombre;
        }

        public void Avanzar(int distancia, int tiempo)
        {
            Posicion += distancia;
            TiempoTotal += tiempo;
        }
    }
}