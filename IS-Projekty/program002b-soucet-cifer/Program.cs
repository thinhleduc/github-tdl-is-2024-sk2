using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("******* Součet a součin cifer *******");
            Console.WriteLine("*************************************");
            Console.WriteLine("*********** Thinh Duc Le ************");
            Console.WriteLine("*************************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte celé číslo: ");
            string input = Console.ReadLine();
            int number;
            while(!int.TryParse(input, out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
                input = Console.ReadLine();
            }

            // Výpis vstupní hodnoty
            Console.WriteLine("===========================");
            Console.WriteLine("Zadané hodnoty: "); 
            Console.WriteLine("Uživatel zadal: {0}", number);
            Console.WriteLine("===========================");

            string numberString = Math.Abs(number).ToString();
            int sum = 0; 

            foreach (char digitChar in numberString)
            {
                
                int digitValue = digitChar - '0';
                sum += digitValue;
                Console.WriteLine("Aktuální zbytek = {0}", digitChar);
            }

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", number, sum);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();
        }
    }
}