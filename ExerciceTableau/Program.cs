using System;

namespace ExerciceTableau
{
    class Program
    {
        private static int n;

        static void Main(string[] args)
        {
            int[] tab = {2,8,13,11,6,3,2,1}; // le tableau initial
            int elem = tab[0]; //la valeur maximale a stocké
 
                for (int i = 0; i <n; i++)
                {
                    if (tab[i] > elem)
                    {
                        elem = tab[i];
                    }
                }
            Console.WriteLine(elem);
        }
    }
}
