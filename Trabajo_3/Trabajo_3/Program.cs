namespace Trabajo_3;
class Program {

    public static void Main(String[] args) {

       // int a = hash(27);
       // Console.WriteLine("Resultado del Hash: " + a);


    // Prueba para Wordle
        string word = "input";
        string guess = "indpo";

        for (int i = 0; i < word.Length; i++){
            if (guess[i] == word[i]){
                Console.WriteLine("verde");
            }
            else if (word.Contains(guess[i])){
                Console.WriteLine("amarillo");
            }
            else {
                Console.WriteLine("gris");
            }
        }


        Console.ReadKey();
    }

    public static int hash(int x) {
        return x % 11;
    }

}