using System;

namespace ExerciceTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = {2,8,13,11,6,3,2,1};
            int elem = 13;

            void AfficherIndice()
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    if (tab[i] > elem)
                    {
                        elem = tab[i];
                    }
                }

            }
            AfficherIndice();
        }
    }
}