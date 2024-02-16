using System;
using System.Collections.Generic;
// Clase para representar citas médicas
public class CitaMedica
{
    public DateTime FechaHora { get; set; }
    public string Paciente { get; set; }
    public string Medico { get; set; }

    public CitaMedica(DateTime fechaHora, string paciente, string medico)
    {
        FechaHora = fechaHora;
        Paciente = paciente;
        Medico = medico;
    }
}

// Clase para representar personas
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Telefono { get; set; }

    public Persona(string nombre, int edad, string telefono)
    {
        Nombre = nombre;
        Edad = edad;
        Telefono = telefono;
    }
}

// Clase principal del programa
class Program
{
    static List<CitaMedica> citas = new List<CitaMedica>();
    static List<Persona> personas = new List<Persona>();

    static void Main(string[] args)
    {
        // Mostrar menú
        MostrarMenu();
    }

    static void MostrarMenu()
    {
        Console.WriteLine("1. Agregar cita");
        Console.WriteLine("2. Mostrar citas");
        Console.WriteLine("3. Agregar persona");
        Console.WriteLine("4. Mostrar personas");
        Console.WriteLine("5. Salir");

        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                AgregarCita();
                break;
            case 2:
                MostrarCitas();
                break;
            case 3:
                AgregarPersona();
                break;
            case 4:
                MostrarPersonas();
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
        }

        MostrarMenu();
    }

    static void AgregarCita()
    {
        Console.Write("Ingrese la fecha y hora de la cita (YYYY-MM-DD HH:MM): ");
        DateTime fechaHora = DateTime.Parse(Console.ReadLine());

        Console.Write("Ingrese el nombre del paciente: ");
        string paciente = Console.ReadLine();

        Console.Write("Ingrese el nombre del médico: ");
        string medico = Console.ReadLine();

        citas.Add(new CitaMedica(fechaHora, paciente, medico));

        Console.WriteLine("Cita agregada correctamente.");
    }

    static void MostrarCitas()
    {
        Console.WriteLine("Citas médicas registradas:");
        foreach (var cita in citas)
        {
            Console.WriteLine($"Fecha y hora: {cita.FechaHora}, Paciente: {cita.Paciente}, Médico: {cita.Medico}");
        }
    }

    static void AgregarPersona()
    {
        Console.Write("Ingrese el nombre de la persona: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la edad de la persona: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de teléfono de la persona: ");
        string telefono = Console.ReadLine();

        personas.Add(new Persona(nombre, edad, telefono));

        Console.WriteLine("Persona agregada correctamente.");
    }

    static void MostrarPersonas()
    {
        Console.WriteLine("Personas registradas:");
        foreach (var persona in personas)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}, Teléfono: {persona.Telefono}");
        }
    }
}