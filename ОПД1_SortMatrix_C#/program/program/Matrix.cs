using System.Globalization;
using System.Text.RegularExpressions;

namespace program
{
    public class SortMatrix
    {
        // Сортировка пузырьком в порядке возрастания
        public static int[,] BubbleSortUp(int[,] matr, comparison comp)
        {
            int[] mas = comp(matr);
            int flag = 1;
            while (flag == 1)
            {
                flag = 0;
                for (int i = 0; i < matr.GetLength(0) - 1; i++)
                {
                    if (mas[i] > mas[i + 1])
                    {
                        for (int j = 0; j < matr.GetLength(1); j++)
                        {
                            int tmp = matr[i, j];
                            matr[i, j] = matr[i + 1, j];
                            matr[i + 1, j] = tmp;
                        }
                        int tmp1 = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = tmp1;
                        flag = 1;
                    }
                }
            }
            return matr;
        }

        // Сортировка пузырьком в порядке убывания
        public static int[,] BubbleSortDown(int[,] matr, comparison comp)
        {
            int[] mas = comp(matr);
            int flag = 1;
            while (flag == 1)
            {
                flag = 0;
                for (int i = 0; i < matr.GetLength(0) - 1; i++)
                {
                    if (mas[i] < mas[i + 1])
                    {
                        for (int j = 0; j < matr.GetLength(1); j++)
                        {
                            int tmp = matr[i, j];
                            matr[i, j] = matr[i + 1, j];
                            matr[i + 1, j] = tmp;
                        }
                        int tmp1 = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = tmp1;
                        flag = 1;
                    }
                }
            }
            return matr;
        }
    }


    public class SummaRows
    {
        public static int[] summa(int[,] matr)
        {
            int[] sum = new int[matr.GetLength(0)];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                sum[i] = 0;
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    sum[i] += matr[i, j];
                }
            }
            return sum;
        }
    }


    public class MaxEl
    {
        public static int[] max(int[,] matr)
        {
            int[] max = new int[matr.GetLength(0)];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                max[i] = 0;
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] > max[i]) max[i] = matr[i, j];
                }
            }
            return max;
        }
    }
        

    public class MinEl
    {
        public static int[] min(int[,] matr)
        {
            int[] min = new int[matr.GetLength(0)];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                min[i] = 1000000000;
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] < min[i]) min[i] = matr[i, j];
                }
            }
            return min;
        }
    }

}