using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        /*ArrayList myAl = new ArrayList();
        myAl.Add("Hello");
        myAl.Add("World");
        myAl.Add("!");
        foreach (object s in myAl)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("==================================");
        ArrayList Carnivoros = new ArrayList();
        ArrayList Acuaticos = new ArrayList();
        ArrayList Animales = new ArrayList();
        Carnivoros.Add("Leon");
        Carnivoros.Add("Tigre");
        Carnivoros.Add("Lobo");
        Acuaticos.Add("Tiburon");
        Acuaticos.Add("Delfin");
        Acuaticos.Add("Ballena");
        Animales.AddRange(Carnivoros);
        foreach (object s in Animales)
        {
            Console.WriteLine(s.ToString());
        }
        Console.WriteLine("==================================");
        Animales.AddRange(Acuaticos);
        foreach (object s in Animales)
        {
            Console.WriteLine(s.ToString());
        }
        string ? palabra;
        int idx;
        ArrayList Materias = new ArrayList();
        ArrayList cursos = new ArrayList();
        Materias.Add("Matematicas");
        Materias.Add("Español");
        Materias.Add("Ingles");
        Materias.Add("Programacion");
        cursos.Add("Octavo");
        cursos.Add("Noveno");
        Console.WriteLine("EScriba una materia buscar: ");
        palabra = Console.ReadLine();
        Console.WriteLine(Materias.Contains(palabra) ? "Si existe" : "No existe");
        do{
            Console.Write("Ingrese la  posicion donde desea insertar la asignatura: ");
            idx= Convert.ToInt32(Console.ReadLine());
        }while(idx > Materias.Count);
        Materias.InsertRange(idx, cursos);
        foreach (object materia in Materias)
        {
            Console.WriteLine(materia.ToString());
        }*/
        // int [] arreglo = new int[5];
        // for (int i = 0; i < arreglo.Length; i++)
        // {
        //     Console.Write("Ingrese un numero: ");
        //     arreglo[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // foreach (int numero in arreglo)
        // {
        //     Console.WriteLine(numero);
        // }
        // ArrayList Arreglos = new ArrayList();
        // Arreglos.Add(1);
        // Arreglos.AddRange(arreglo);
        // foreach (int numero in Arreglos)
        // {
        //     Console.WriteLine(numero);
        // }
        /*ArrayList Materias = new ArrayList();
        Materias.Add("Matematicas");
        Materias.Add("Español");
        Materias.Add("Ingles");

        string[] MyArray = (string[])Materias.ToArray(typeof(string));
        foreach (string materia in MyArray)
        {
            Console.WriteLine(materia);
        }*/
        ArrayList Materias = new ArrayList();
        String[] especialidad = {"Sistemas","Mecatronica","Industrial","Gestion Empresarial","Energias Renovables","Tecnologias de la Informacion"};
        Materias.Add("Calculo");
        Materias.Add("Español");
        Materias.Add("Dibujo Tecnico");
        Materias.Add(especialidad);
        /* foreach (Object dato in Materias){
                    Console.WriteLine(dato.GetType());
        } /
        foreach (Object dato in Materias){
            if (dato.GetType() == typeof(System.String[])){
                foreach (String dato2 in (String[])dato){
                    Console.WriteLine(dato2);
                }
            } 
            / else{
                Console.WriteLine(dato.ToString());
            } */
        }
    }