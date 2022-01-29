using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovePegs
{
    internal class Program
    {
        /// <summary>
        /// Write program to remove pegs from a grid. Pegs can be removed if there are other pegs in the same row or column. Find max pegs that can be removed.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int removedPegsCount = RemovePegs();
            Console.WriteLine(removedPegsCount);
            Console.ReadLine();
        }

        private static int RemovePegs()
        {
            int pegsRemoved = 0;
            const int size = 3;
            int[,] matrix = new int[size, size] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            int[,] matrixResultant = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] == 1 && IsPegRemovable(i, j, matrix, size))
                    {
                        matrixResultant[i, j] = 1;
                        pegsRemoved++;
                    }
                }
            }
            return pegsRemoved;
        }

        private static bool IsPegRemovable(int i,int j,int[,] matrix,int size)
        {

            for( int k = 0; k < size; k++)
            {
                if((matrix[i,k] ==1 && k!=j) || (matrix[k,j] ==1) && (i!=k))
                    return true;
            }


            return false;
        }
    }
}
