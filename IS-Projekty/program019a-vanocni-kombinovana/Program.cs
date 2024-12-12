using System;
using System.Collections.Specialized;
using System.Diagnostics;

class Program {

    static void Main() {



		//			GENERATOR


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

            Stopwatch myStopwatch1 = new Stopwatch();

            myStopwatch1.Start();

			for(int i = 0; i < n-1 ; i++) {
                for(int j = 0; j < n-i-1; j++) {
                    if(numbers[j] < numbers[j+1]) {
                        int tmp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j+1] = tmp;
                    }
                }
            }

            myStopwatch1.Stop();
            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i=0; i < n; i++){
                Console.Write("{0}; ", numbers[i] );
            }
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmu pomocí Comb Sort: {0}", myStopwatch1.Elapsed);

            int sum = 0;

			for (int i = 0; i < n; i++) {
				sum += numbers[i];
			}

			int rest = sum % n;
			int wholeAverage = (sum - rest) / n;

			Console.WriteLine("Suma: {0}", sum);
			Console.WriteLine("Celkový průměr: {0}", wholeAverage);
			Console.WriteLine("Zbytek: {0}", rest);




            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}

namespace CombSort {
	public static class CombSort {
		public static void Sort(int[] array) {
			int gap = array.Length;
			bool swapped = true;

			while (gap != 1 || swapped) {
				gap = GetNextGap(gap);
				swapped = false;
				for (int i = 0; i < array.Length - gap; i++) {
					if (array[i] > array[i + gap]) {
						int temp = array[i];
						array[i] = array[i + gap];
						array[i + gap] = temp;
						swapped = true;
					}
				}
			}
		}

		private static int GetNextGap(int gap) {
			gap = (gap * 10) / 13;
			if (gap < 1) return 1;
			return gap;
		}
	}
}
