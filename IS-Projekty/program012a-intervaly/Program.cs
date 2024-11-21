using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Generátor pseudonáhodných čísel *******");
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
            int[] myArray = new int[n];

            Random randomNumber = new Random();

            int interval1=0;
            int interval2=0;
            int interval3=0;
            int interval4=0;

            Console.WriteLine("\n\nNáhodná čísla:");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);

                if(myArray[i]<= (0.25 * hm)) {
                    interval1++;
                }
                else if(myArray[i] <= (0.5 * hm)) {
                    interval2++;
                }
                else if(myArray[i] <= (0.75 * hm)) {
                    interval3++;
                }
                else
                    interval4++; 
           }

            Console.WriteLine("\nInterval <{0}, {1}>: {2}", dm, 0.25 * hm, interval1);
            Console.WriteLine("Interval <{0}, {1}>: {2}", 0.25 * hm + 1, 0.5 * hm, interval2);
            Console.WriteLine("Interval <{0}, {1}>: {2}", 0.5 * hm + 1, 0.75 * hm, interval3);
            Console.WriteLine("Interval <{0}, {1}>: {2}", 0.75 * hm  + 1, hm, interval4);

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}
