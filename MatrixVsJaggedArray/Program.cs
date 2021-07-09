using System;

namespace MatrixVsJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            JaggedArray1();
            //---------------------------------------

            JaggedArray2();

            //---------------------------------------
            Matrix1();

            //---------------------------------------
            Matrix2();

        }

        private static int[][] InitializingJaggedArray(int[] measures)
        {
            Console.WriteLine("Initializing jagged-array....");
            int[][] res = new int[measures.Length][];
            int numOfCols;
            for (int j = 0; j < res.Length; j++)
            {
                Console.WriteLine("Initializing the row(" + j + ").... ");

                numOfCols = measures[j];
                res[j] = new int[numOfCols];
                for (int k = 0; k < res[j].Length; k++)
                {
                    res[j][k] = EnterPositiveNonZeroInt();
                }
            }
            return res;
        }
        //=======================================================================================
        private static void JaggedArray2()
        {
            Console.WriteLine("Initialzing a jagged-Array....");
            int[] yourMeasures = JaggedArrayMeasures();
            int[][] yourJaggedArray = InitializingJaggedArray(yourMeasures);
            PrintJaggedArray(yourJaggedArray);
            Console.WriteLine();
        }

        private static int[] JaggedArrayMeasures()
        {
            Console.Write("Enter the number of rows: ");
            int numOfRows = EnterPositiveNonZeroInt();
            int[] measures = new int[numOfRows];
            for (int i = 0; i < measures.Length; i++)
            {
                Console.Write("Enter the number of columns in the row(" + i + ")...: ");
                measures[i] = EnterPositiveNonZeroInt();
            }
            return measures;
        }

        private static void JaggedArray1()
        {
            int[][] z = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9, 10 }
            };
            int[][] y = new int[5][];
            y[0] = new int[] { 1, 2 };
            y[1] = new int[] { 3, 4, 5 };
            y[2] = new int[] { 6 };
            y[3] = new int[] { 7, 8, 9, 10, 11, 12, 13, 14 };
            y[4] = new int[] { 15, 16, 17, 18 };
            Console.WriteLine("Printing jagged-array....");
            PrintJaggedArray(z);
            Console.WriteLine("Printing jagged-array....");
            PrintJaggedArray(y);
            Console.WriteLine();
        }
        private static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        private static void Matrix1()
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5,6 }, { 7, 8, 9}
            };
            PrintMatrix(a);
            Console.WriteLine();
        }
        private static void Matrix2()
        {
            Console.WriteLine("Initialzing a matrix....");
            Console.Write("Enter the number of rows...: ");
            int numOfRows = EnterPositiveNonZeroInt();
            Console.Write("Enter the number of columns: ");
            int numOfColumns = EnterPositiveNonZeroInt();
            Console.WriteLine("Your matrix is initializing now....");
            var YourMatrix = InitializeMatrix(numOfRows, numOfColumns);
            PrintMatrix(YourMatrix);
            Console.WriteLine();
        }
        private static void PrintMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        private static int[,] InitializeMatrix(int rows, int columns)
        {
            int[,] mat = new int[rows, columns];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = EnterPositiveNonZeroInt();
                }
            }
            return mat;
        }
        private static void InitializeMatrix(int[,] mat)
        {
            int NumOfDim = mat.Rank;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = EnterPositiveNonZeroInt();
                }
            }
        }
        private static int EnterPositiveNonZeroInt()
        {
            int a = 0;
            string str = " ";
            try
            {
                str = Console.ReadLine();
                a = int.Parse(str);
                if (a <= 0)
                    throw new ArgumentException();
                return a;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Re-enter you number (>0): ");
                return EnterPositiveNonZeroInt();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Enter a valid number: ");
                return EnterPositiveNonZeroInt();
            }
        }
    }
}
