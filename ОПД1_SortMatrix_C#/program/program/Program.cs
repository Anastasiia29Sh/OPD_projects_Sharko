using program;
using System.Globalization;
using System.Text.RegularExpressions;

public delegate int[] comparison(int[,] matr);

class Program
{
    public static void Main()
    {

        int[,] matrix = new int[4, 3] { { 6, 5, 4 }, { 3, 62, 1 }, { 61, 5, 9 }, { 18, 2, 15 } };
        int[,] resmatrix = new int[4, 3];

        comparison comp;

        // В порядке возрастания сумм элементов строк матрицы
        comp = new comparison(SummaRows.summa);
        resmatrix = SortMatrix.BubbleSortUp(matrix, comp);
        PrintMatrix(resmatrix);

        // В порядке убывания сумм элементов строк матрицы
        resmatrix = SortMatrix.BubbleSortDown(matrix, comp);
        PrintMatrix(resmatrix);


        // По возрастанию максимального элемента в строке матрицы
        comp = new comparison(MaxEl.max);
        resmatrix = SortMatrix.BubbleSortUp(matrix, comp);
        PrintMatrix(resmatrix);

        // По убыванию максимального элемента в строке матрицы
        resmatrix = SortMatrix.BubbleSortDown(matrix, comp);
        PrintMatrix(resmatrix);


        // В порядке возрастания минимального элемента в строке матрицы
        comp = new comparison(MinEl.min);
        resmatrix = SortMatrix.BubbleSortUp(matrix, comp);
        PrintMatrix(resmatrix);


        // В порядке убывания минимального элемента в строке матрицы
        comp = new comparison(MinEl.min);
        resmatrix = SortMatrix.BubbleSortDown(matrix, comp);
        PrintMatrix(resmatrix);



        void PrintMatrix(int[,] resmatrix)
        {
            Console.WriteLine("\nРезультат сортировки:");
            for (int i = 0; i < resmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resmatrix.GetLength(1); j++)
                {
                    Console.Write(resmatrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }


    }
}