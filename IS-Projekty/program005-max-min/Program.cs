using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********** Maximum a minimum čísel ***********");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***************** Thinh Duc Le ****************");
            Console.WriteLine("*******************************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet generovaných čísel (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n=====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("=====================\n\n");

            //deklarace pole
            int[]myArray = new int[n];

            //příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i=0; i < n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }

            // Nalezení maximálního a minimálního čísla a jejich pozice
            int max = myArray[0];
            int min = myArray[0];
            int maxIndex = 0;
            int minIndex = 0;

            for(int i=1 ; i < n; i++){
                if(myArray[i] > max) {
                    max = myArray[i];
                    maxIndex = i;
                }

                if(myArray[i] < min) {
                    min = myArray[i];
                    minIndex = i;
                }
            }

            // Výpis maximálního a minimálního čísla
            Console.WriteLine("\n\nNejvyšší číslo: {0}", max);
            Console.WriteLine("Nejnižší číslo: {0}", min);

            // Výpis pozice maximálního čísla v poli
            Console.WriteLine("\n\nPozice nejvyššího čísla: {0}", maxIndex);
            Console.WriteLine("Pozice nejnižšího čísla: {0}", minIndex);


            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}
