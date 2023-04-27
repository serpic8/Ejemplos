using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

List <Persona> listaPersona = new List<Persona>();
Persona per = new Persona();
string nombre;
int valorEdad;
string correo;
string filename = "Persona.XML";
string jsonString = string.Empty;
bool salida = true;



//Escoja una opcion
Console.WriteLine("Registro Persona");
while (salida)
{
    Console.WriteLine("Elija una opcion");
    Console.WriteLine("\ts - Crear y serializar registro");
    Console.WriteLine("\td - Deserializar registro");
    Console.WriteLine("\tc - Salir del programa");
    string op = Console.ReadLine();

    switch (op)
    {
        case "s":
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad");
            valorEdad = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Ingrese el correo electronico");
            correo = Console.ReadLine();

            //Agregar los elementos a la lista

            per.Nombre = nombre;
            per.Edad = valorEdad;
            per.CorreoElectronico = correo;
            listaPersona.Add(per);
              
            
            Console.WriteLine("Registro a serializar");
            Console.WriteLine(per.ToString());

            Console.WriteLine("----Serializamos----");
            jsonString = JsonSerializer.Serialize(listaPersona);
            File.WriteAllText(filename, jsonString);
            Thread.Sleep(3000);
            Console.WriteLine("Listo.....");
            Thread.Sleep(1000);

            break;

        case "d":
            Console.WriteLine("\n----Deserializamos----");

            jsonString = File.ReadAllText(filename);
            List<Persona> listaPerson= JsonSerializer.Deserialize<List<Persona>>(jsonString)!; 


            Console.WriteLine("Objetos deserializados son:");
            foreach (var persona in listaPerson)
            {
                Console.WriteLine(per.ToString()); 
            }
            break;

        case "c":
            Console.WriteLine("SALIENDO DE LA APP");
            Thread.Sleep(3000);
            Console.WriteLine("Adios.....");
            salida = false;

            break;
        default:
            Console.WriteLine("Opcion Incorrecta");
            break;
    }

}

//Se acumulan pero los datos se sobreescriben por los ultimos datos agreagdos

[Serializable]
public class Persona
{
    private string nombre;
    private int edad;
    private string correoElectronico;

    public Persona() : this("",0,"")
    {

    }

    public Persona(string Vnombre, int Vedad, string VcorreoElectronico)
    {
        Nombre = Vnombre;
        Edad = Vedad;
        CorreoElectronico = VcorreoElectronico;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
    public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }

    public override string ToString()
    {
        return "Nombre: " + Nombre + "\n" +
            "Edad: " + Edad + "\n" +
            "Correo: " + CorreoElectronico;
    }
}
    

