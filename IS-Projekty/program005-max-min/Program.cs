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
             int posMax = 0;
             int posMin = 0;
             int maxcount = 1;
             int mincount = 1;
             string maxpozice = " ";
             string minpozice = " ";

             for(int i=1 ; i < n; i++){
                if(myArray[i] == max){
                    maxcount++;
                    maxpozice+= i+ "; ";
                }
                if(myArray[i] == min){
                    mincount++;
                    minpozice+= i+ "; ";
                }
                if(myArray[i] > max){
                    max = myArray[i];
                    posMax = i;
                }
                 if(myArray[i] < min){
                    min = myArray[i];
                    posMin = i;
                }
             }  
            Console.WriteLine("\nmaximální číslo: {0}", max +" má první pozici: " + posMax);
            Console.WriteLine("minimální číslo: {0}", min +" má první pozici: " + posMin);
            Console.WriteLine("maximální hodnota je zde : {0}x", maxcount);
            Console.WriteLine("další maximální hodnoty jsou na pozicích: " +maxpozice);
            Console.WriteLine("minimální hodnota je zde : {0}x", mincount);
            Console.WriteLine("další minimální hodnoty jsou na pozicích: "+minpozice);


            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}
