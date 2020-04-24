using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_zadatal_RPPOON_LV3
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random random;

        private MatrixGenerator()
        {
            this.random = new Random();
        }
        public static MatrixGenerator GetInstance()
        {
            if(instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public double[][] CreateMatrix(int column, int row)
        {
            double[][] matrix = new double[row][];
            for(int i = 0; i < row; i++)
            {
                matrix[i] = new double[column];
            }
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    matrix[i][j] = this.random.NextDouble();
                }
            }
            return matrix;
        }
    }
}
