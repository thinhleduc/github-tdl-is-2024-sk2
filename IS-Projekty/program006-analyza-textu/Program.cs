using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("******* Analýza textu *******");
            Console.WriteLine("*****************************");
            Console.WriteLine("******* Thinh Duc Le ********");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele 
            Console.Write("\n Zadejte text pro analýzu: ");
            string myText = Console.ReadLine();
            string samohlasky = "aáeéiíoóuůúyýAÁEÉIÍOÓUŮÚYÝ";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzžBCČDĎFGHJKLMNŇPQRŘSŠTŤVWXZŽ";
            string cislice = "0123456789";

            int pocetSam = 0;
            int pocetSou = 0;
            int pocetCis = 0;
            int pocetOst = 0;

            foreach (char znak in myText){
                if (samohlasky.Contains(znak)) {
                    pocetSam++;
                } else if (souhlasky.Contains(znak)) {
                    pocetSou++;
                } else if (cislice.Contains(znak)){
                    pocetCis++;
                } else
                    pocetOst++;
            }

            Console.WriteLine("\n\nPočet samohlásek: {0}", pocetSam);
            Console.WriteLine("Počet souhlásek: {0}", pocetSou);
            Console.WriteLine("Počet číslic: {0}", pocetCis);
            Console.WriteLine("Počet ostatních: {0}", pocetOst);



            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}
