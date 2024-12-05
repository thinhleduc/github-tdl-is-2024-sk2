using System.Data;
using System.Net.Security;

string again = "a";
while(again == "a") {
    Console.Clear();
            ulong a = getCislo("Zadejte číslo a: ");
            ulong b = getCislo("Zadejte číslo b: ");
            
            ulong nsd = vypocetNSD(a, b);
            ulong nsn = vypocetNSN(a, b, nsd);
            
            vysledky(a, b, nsd, nsn);

            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }

        static ulong getCislo(string zprava) {
            Console.Write(zprava);
            ulong cislo;
            while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write("Nebylo zadáno přirozené číslo!!! Zadejte znovu: ");
            }    
            return cislo;
        }

        static ulong vypocetNSD(ulong a, ulong b) {
            while(a != b) {
                if(a > b)
                    a = a - b;
                else
                    b = b - a;     
            }
            return a;
        }

        static ulong vypocetNSN(ulong a, ulong b, ulong nsd) {
            return (a*b)/nsd;
        }

        static void vysledky(ulong a, ulong b, ulong nsd, ulong nsn) {
            Console.WriteLine("\n\nNSD čísel {0} a {1} je {2}", a, b, nsd);
            Console.WriteLine($"\nNSN čísel {a} a {b} je {nsn}");
        }