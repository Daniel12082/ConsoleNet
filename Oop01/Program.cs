using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Oop01.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList Datos = new ArrayList();
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Imprimir estudiante");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Datos.InsertRange(0,AddStudent());
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    PrintStudent(Datos);
                    Console.ReadKey();
                    break;
                case 3:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
    public static ArrayList AddStudent()
    {   
        ArrayList Info = new ArrayList();
        Estudiantes estudiante = new Estudiantes();
        estudiante.Id = Guid.NewGuid().ToString();
        Console.WriteLine($"Id del estudiante: {Guid.NewGuid().ToString()}");
        Console.WriteLine("Ingrese el nombre del estudiante: ");
        estudiante.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el email del estudiante: ");
        estudiante.Email = Console.ReadLine();
        Console.WriteLine("Ingrese la edad del estudiante: ");
        estudiante.Edad = int.Parse(Console.ReadLine());
        Info.Add(estudiante);
        return(Info);
    }
    public static void PrintStudent(ArrayList Datos)
    {
        Console.WriteLine("Lista de estudiantes");
        Console.WriteLine("{0,10} {1,40}","Cod Estudiante","Nombre Estudiante");
        foreach (Estudiantes estudiante in Datos)
        {
            Console.WriteLine("{0,10} {1,40}",estudiante.Id,estudiante.Nombre);
        }
    }
}