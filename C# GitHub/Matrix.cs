using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV321
{
    interface ICalc
    {
        int Less(int valueToCompare); //повертає кількість менших значень ніж valueToCompare
        int Greater(int valueToCompare); //повертає кількість більших значень, ніж valueToCompare.
        int CountDistinct(); //— повертає кількість унікальних значень у контейнері даних;
        int EqualToValue(int valueToCompare); //— повертає кількість значень, рівних valueToCompare.
    }

    interface IOutput
    {
        void ShowEven(); // — відображає парні значення контейнера з даними;
        void ShowOdd();  // — відображає непарні значення контейнера з даними.
    }
    public class Matrix : ICalc, IOutput
    {

        int[,] array;
        public int Rows { get; }
        public int Cols { get; }

        public delegate void _mArray(Matrix m);

        public Matrix(int row, int col)
        {
            Rows = row;
            Cols = col;
            array = new int[row, col];
        }

        public void SetRandom()
        {
            Random r = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    array[i, j] = r.Next(0, 10);
                }
            }
        }

        public void printMatrix()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        
        public void ShowEven()
        {
            for(int i = 0;i < Rows;i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (array[i, j] % 2 == 0) Console.Write($"{array[i, j]} ");
                    Console.WriteLine();
                }
            }
        }

        public void ShowOdd()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (array[i, j] % 2 == 1) Console.Write($"{array[i, j]} ");
                    Console.WriteLine();
                }
            }
        }
        public int Less(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (array[i, j] < valueToCompare) count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (array[i, j] > valueToCompare) count++;
                }
            }
            return count;
        }

        public int CountDistinct()
        {
            int count = 0;
            int[] rr = new int[Rows], cc = new int[Cols];
            int[] unique = rr.Union(cc).ToArray(); //не знаю на скільки правильний цей варіант

            for (int i = 0; i < unique.Length; i++) count++;
            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for(int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (array[i, j] == valueToCompare) count++;
                }
            }
            return count;
        }

        public int this[int r]
        {
            get { return array[r, r]; }
            set { array[r, r] = value; }
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }

    }
}
