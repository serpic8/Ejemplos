using Serializable;
using System.Text.Json;

Console.WriteLine("Serializacion con JSON");
Console.WriteLine("----------------------");

Datos registro = null;
int id;
string nombre = "";
string nCuenta = "";
decimal saldo = 0.0M;
string filename = "Cuentas.json";
string jsonString = string.Empty;

Console.WriteLine("Escoga una opcion");
Console.WriteLine("\ts - Crear y serializar el registro");
Console.WriteLine("\td - Deserealizar el registro");
Console.WriteLine("Su opcion?");
string op = Console.ReadLine();

switch (op)
{
	case "s":
        Console.WriteLine("Ingrese el id de la cuenta y presione enter");
		id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el nombre y presione enter");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el numero de cuenta y presione enter");
        nCuenta = Console.ReadLine();
        Console.WriteLine("Ingrese el saldo y presione enter");
        saldo = decimal.Parse(Console.ReadLine());
		registro = new Datos(id,nombre, nCuenta, saldo);

        Console.WriteLine("\n");
        Console.WriteLine("Registro a Serializar");
        Console.WriteLine(registro.ToString());

        Console.WriteLine("Serializamos");
		jsonString = JsonSerializer.Serialize(registro);
		File.WriteAllText(filename, jsonString);

        break;

	case "d":
        Console.WriteLine("Deserealizamos");

		jsonString = File.ReadAllText(filename);
		registro = JsonSerializer.Deserialize<Datos>(jsonString)!;

        Console.WriteLine("El registro deserealizado es");
        Console.WriteLine(registro.ToString());
        break;
	default:
        Console.WriteLine("Opcion invalida");
        break;
}



