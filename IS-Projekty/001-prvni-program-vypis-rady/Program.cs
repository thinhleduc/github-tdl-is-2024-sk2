using System;

class Program {

    static void Main() {

        //Po stisku klávesy "a" se program bude opakovat
        string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("******* Výpis řady *******");
            Console.WriteLine("*****************");
            Console.WriteLine("****** Thinh Duc Le*******");
            Console.WriteLine("**************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - TO DO

            // Logika pro výpis řady - TO DO

            // Opakování programu
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
