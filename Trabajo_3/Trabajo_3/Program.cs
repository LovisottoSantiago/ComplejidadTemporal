namespace Trabajo_3;
class Program {

    public static void Main(String[] args) {

        int a = hash(27);
        Console.WriteLine("Resultado del Hash: " + a);

        Console.ReadKey();
    }

    public static int hash(int x) {
        return x % 11;
    }

}