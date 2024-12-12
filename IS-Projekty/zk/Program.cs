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
            int n;
			int dm;
			int hm;
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
			while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
			{
				Console.Write("Nezadali jste celé číslo nebo číslo je menší než nula. Zadejte znovu počet generovaných čísel (celé číslo): ");
			}

			Console.Write("Zadejte dolní mez (celé číslo): ");
			while(!int.TryParse(Console.ReadLine(), out dm)) {
				Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
			}

			Console.Write("Zadejte horní mez (celé číslo): ");
			while(!int.TryParse(Console.ReadLine(), out hm) || hm <= dm) {
				Console.Write("Nezadali jste celé číslo nebo je číslo menší než dolní mez. Zadejte znovu horní mez (celé číslo): ");
			}

			int[] numbers = new int[n];
			int max = int.MinValue;
			List<int> maxIndexes = [];
			int min = int.MaxValue;
			List<int> minIndexes = [];

			Random rand = new();
			for (int i = 0; i < n; i++) {
				numbers[i] = rand.Next(dm, hm);

				if (i == 0) {
					max = numbers[i];
					min = numbers[i];
				} else {
					if (numbers[i] > max) {
						max = numbers[i];
						maxIndexes.Clear();
					}
					if (numbers[i] < min) {
						min = numbers[i];
						minIndexes.Clear();
					}
				}

				if (numbers[i] == max) {
					maxIndexes.Add(i);
				}
				if (numbers[i] == min) {
					minIndexes.Add(i);
				}
			}

			Console.WriteLine("Náhodná čísla: ");
			for (int i = 0; i < n; i++) {
				Console.Write("{0} ", numbers[i]);
			}
			Console.WriteLine();

			Console.WriteLine("Max. hodnoty: {0}", max);
			Console.Write("Indexy max. hodnot: ");
			foreach (int index in maxIndexes) {
				Console.Write("{0} ", index);
			}
			Console.WriteLine();

			Console.WriteLine("Min. hodnoty: {0}", min);
			Console.Write("Indexy min. hodnot: ");
			foreach (int index in minIndexes) {
				Console.Write("{0} ", index);
			}
			Console.WriteLine();

            int numberCompare = 0;
            int numberChange = 0;

            for(int i = 0; i < n-1 ; i++) {
                for(int j = 0; j < n-i-1; j++) {
                    numberCompare++;
                    if(numbers[j] < numbers[j+1]) {
                        int tmp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j+1] = tmp;
                        numberChange++;
                    }
                }
            }

            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i=0; i < n; i++){
                Console.Write("{0}; ", numbers[i]);
            }

            Console.WriteLine("\n\n Počet porovnání: {0}", numberCompare);
            Console.WriteLine("\n\n Počet výměn: {0}", numberChange);

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}