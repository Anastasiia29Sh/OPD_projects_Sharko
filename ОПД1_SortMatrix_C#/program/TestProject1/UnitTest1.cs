using NUnit.Framework;
using program;
using System;


namespace TestProject1
{
    //public delegate int[] comparison(Matrix matr);

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        // � ������� ����������� ���� ��������� ����� �������
        [Test]
        public void Test1()
        {
            int[,] a = { { 10, 9, 8 }, { 81, 6, 5 }, { 0, 1, 3 } };
            int[,] my_result = { { 0, 1, 3 }, { 10, 9, 8 }, { 81, 6, 5 } };

            int[,] res = SortMatrix.BubbleSortUp(a, SummaRows.summa);
            Assert.AreEqual(my_result, res);
        }

        // � ������� �������� ���� ��������� ����� �������
        [Test]
        public void Test2()
        {
            int[,] a = { { 10, 9, 8 }, { 81, 6, 5 }, { 0, 1, 3 } };
            int[,] my_result = { { 81, 6, 5 }, { 10, 9, 8 }, { 0, 1, 3 } };

            int[,] res = SortMatrix.BubbleSortDown(a, SummaRows.summa);
            Assert.AreEqual(my_result, res);
        }

        // �� ����������� ������������� �������� � ������ �������
        [Test]
        public void Test3()
        {
            int[,] a = { { 10, 9, 8 }, { 81, 6, 5 }, { 0, 1, 3 } };
            int[,] my_result = { { 0, 1, 3 }, { 10, 9, 8 }, { 81, 6, 5 } };

            int[,] res = SortMatrix.BubbleSortUp(a, MaxEl.max);
            Assert.AreEqual(my_result, res);
        }

        // �� �������� ������������� �������� � ������ �������
        [Test]
        public void Test4()
        {
            int[,] a = { { 10, 9, 8 }, { 81, 6, 5 }, { 0, 1, 3 } };
            int[,] my_result = { { 81, 6, 5 }, { 10, 9, 8 }, { 0, 1, 3 } };

            int[,] res = SortMatrix.BubbleSortDown(a, MaxEl.max);
            Assert.AreEqual(my_result, res);
        }

        // � ������� ����������� ������������ �������� � ������ �������
        [Test]
        public void Test5()
        {
            int[,] a = { { 10, 9, 8 }, { 81, 6, 5 }, { 0, 1, 3 } };
            int[,] my_result = { { 0, 1, 3 }, { 81, 6, 5 }, { 10, 9, 8 } };

            int[,] res = SortMatrix.BubbleSortUp(a, MinEl.min);
            Assert.AreEqual(my_result, res);
        }

        // � ������� �������� ������������ �������� � ������ �������
        [Test]
        public void Test6()
        {
            int[,] a = { { 10, 9, 8 }, { 81, 6, 5 }, { 0, 1, 3 } };
            int[,] my_result = { { 10, 9, 8 }, { 81, 6, 5 }, { 0, 1, 3 } };

            int[,] res = SortMatrix.BubbleSortDown(a, MinEl.min);
            Assert.AreEqual(my_result, res);
        }

    }
}