using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("******* Obrazec 1  *******");
            Console.WriteLine("**************************");
            Console.WriteLine("****** Thinh Duc Le ******");
            Console.WriteLine("**************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele
        int size = getNumber("Zadejte velikost obrazce (celé číslo): ");
        int getNumber(string message) {
            Console.Write(message);
            int number;
        while (!int.TryParse(Console.ReadLine(), out number))
            Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo): ");
        return number;
        }
        bool inverted = false;
        for (int i = 0; i < size; i++) {
            bool space = inverted;
                for (int j = 0; j < size; j++) {
                    if (!space) {
                        Console.Write("* ");
                    } else {
                    Console.Write("  ");
                }
                if (j % 2 == 1) {
                    space = !space;
                }
                }
            if (i % 2 == 1) {
                inverted = !inverted;
            }
        Console.WriteLine();
    }

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}
