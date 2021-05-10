using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            //Napisz przykładowy program, w którym zostaną wygenerowane dwa różne 
            //wyjątki(ArithmeticException, Exception).Wyświetl na ekranie systemowe komunikaty

            int l1 = 10;
            int l2 = 0;

            int[] tab = new int[5];

            try
            {
                int l3 = l1 / l2;
                Console.WriteLine(l3);

                
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }

            try
            {
                tab[10] = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine();
            //Zadanie 2
            //Napisz program, który pobierze od użytkownika tablice 10 liczb całkowitych. 
            //Przekaz tablicę do konstruktora, który posortuje tablicę metodą bąbelkową, 
            //i zwróci tablicę do metody main().Wykorzystaj konstrukcję try – catch (np.przekroczenie zakresu tablicy).

            int[] liczby = new int[10] { 33, 4, 8, 56, 241, 22, 41, 1, 99, 222 };

            BubbleSort bubbleSort = new BubbleSort(liczby);

            Console.ReadKey();
        }
    }

    class BubbleSort
    {
        public BubbleSort(int[] tab)
        {
            try
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    for (int j = 0; j < 100; j++) //np j<100 - OutOfRangeException
                    {
                        int temp = tab[j];
                        if (temp > tab[j + 1])
                        {
                            temp = tab[j + 1];
                            tab[j + 1] = tab[j];
                            tab[j] = temp;
                        }
                    }
                }
                Console.Write("Posortowana tablica: ");
                foreach (int liczba in tab)
                {
                    Console.Write("{0}, ", liczba);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            } 

            
        }
    }
}
