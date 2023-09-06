internal class Program
{
    private static void Main(string[] args)
    {
        List<string> Materias = new List<string>();
        int idx = 0;
        Materias.Add("Matematicas");
        Materias.Add("Español");
        Materias.Add("Ciencias Naturales");
        Materias.Add("Ciencias Sociales");
        Materias.Add("Ingles");
        ContarMaterias(Materias);

        Console.WriteLine("Ingrese la posicion de la materia a buscar: ");
        idx = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"La materia en la posicion {idx} : " + obtenerMateria(Materias, idx));

        Materias.Add(AgregarMateria());

        Console.WriteLine("Ingrese la materia a validar: ");
        if(Validaritem(Materias,Console.ReadLine()))
        {
            Console.WriteLine("La materia ya existe");
        }
        else
        {
            Console.WriteLine("La materia no existe");
        }
        Buscaritem(Materias);
    }
    public static void ContarMaterias(List<string> list)
    {
        Console.WriteLine("La cantidad de materias es: " + list.Count);
    }
    public static string obtenerMateria(List<string> list, int index)
    {
        return list[index];
    }
    public static string AgregarMateria()
    {
        Console.WriteLine("Ingrese la materia a agregar: ");
        return Console.ReadLine();
    }
    public static bool Validaritem (List<string> list, string item)
    {
        return list.Exists(x => x.ToLower().Equals(item.ToLower()));
    }
    public static void Buscaritem(List<string> list)
    {
        String palabra= null;
        Console.WriteLine("Ingrese la materia a buscar: ");
        palabra = Console.ReadLine();
        string nombre = list.Find(x => x.StartsWith(palabra ?? String.Empty));
        Console.WriteLine(nombre != null ? "Se encontro la materia" : "No se encontro la materia"); 
    }
}