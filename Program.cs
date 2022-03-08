using System; 
namespace vierNimmt{
    class Programm{
        static int inputP1;
        static int anzahl;
        int currentPlayer = 1; 

        static void Main(string[] args){
            Console.WriteLine("Hello world! Ich lebe");
            Console.WriteLine("Mit wievielen Streichhölzern soll begonnen werden?");
            anzahl = Convert.ToInt32(Console.ReadLine());

            if(anzahl % 4 != 0){
                Console.WriteLine("Okay dann fange ich mal an.");
                aktionKI();
                Console.WriteLine("Neue Anzahl ist: " + anzahl);
            }

            Console.WriteLine("Okay du bist!; gib einfach ein wieviele du wegnehmen möchtest");
            while(anzahl > 1){
                do{
                inputP1 = Convert.ToInt32(Console.ReadLine());
                }while(inputP1 > 3 || inputP1 < 1);
                Console.WriteLine("Du nimmst " + inputP1 + " Streichhölzer weg.");
                anzahl = anzahl - inputP1; 
                Console.WriteLine("Neue Anzahl ist: " + anzahl);
                
                aktionKI();
                Console.WriteLine("Neue Anzahl ist: " + anzahl);
            }

            Console.WriteLine("Ich habe gewonnen; niemand schlägt einen Komputer!");
        }

        static void aktionKI(){
            int p = anzahl % 4;
            Console.WriteLine("Ich nheme mir " + p + " Streichhölzer weg.");
            anzahl = anzahl - p;
        }
    }
}