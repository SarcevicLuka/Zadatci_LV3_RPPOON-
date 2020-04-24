using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_zadatal_RPPOON_LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixGenerator matrixGenerator = MatrixGenerator.GetInstance();
            double[][] matrix = matrixGenerator.CreateMatrix(3, 3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}

/*Metoda CreateMatrix ima dvije odgovornosti; stvaranje matrice i popunjavanje matrice*/
