using System;
using System.Collections.Specialized;
using System.Net.Security;

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
            Console.Write("Zadejte počet generovaných čísel (přirozené číslo): ");
            uint n;
            while(!uint.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Špatný vstup. zadejte znova (přirozené číslo): ");
            }

            uint[] myArray = new uint[32];
            uint zaloha = n;
            uint zbytek;

            uint i = 0;
            while(n > 0){
                zbytek = n % 2;
                n = (n - zbytek) / 2;
                myArray[i] = zbytek;

                Console.WriteLine("Celá část = {0}; zbytek = {1}", n, zbytek);

                i++;
            }
            Console.Write("Poslední využitý index pole: {0}", i - 1);
            Console.WriteLine("\n\nVýsledek: ");
            for(uint j = i - 1; j >= 0 ;j--){
                Console.Write("{0} ", myArray[j]);
            }


            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}

