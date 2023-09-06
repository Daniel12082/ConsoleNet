internal class Program
{
    private static void Main(string[] args)
    {
        double d = 3D;
        d = 4d;
        d = 3.934_001;
        Console.WriteLine($"{d}");
        float f = 3_0000.5F;
        f = 5.4f;
        Console.WriteLine($"{f}");
        decimal myMoney = 3000.5M;
        myMoney = 400.75M;
        Console.WriteLine($"{myMoney}");
        bool check = true;
        Console.WriteLine(check ? "activo" : "inactivo");
        Console.WriteLine(false ? "activo" : "inactivo");
        decimal myMoney2 = 3000.56m;
        Console.WriteLine(myMoney2.ToString("C0"));
        }
}