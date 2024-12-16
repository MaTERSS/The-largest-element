/*
Найти наибольший элемент матрицы A(10,10) и записать ноль в те ячейки, где он находятся. Вывести наибольший элемент, исходную и полученную матрицу. 

Массив под измененную версию не нужен.
 */
using System;
using System.Text;

namespace CSharplight
{
    internal class Progrmm
    {
        static void Main(string[] args)
        {
            int rows = 10; 
            int columns = 10;
            int minValue = 1;
            int maxValue = 51;
            int maxElement;
            int[,] matrix = new int[rows, columns];

            Random random = new Random();

            Console.WriteLine("Исходная матрица:");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue); 
                    Console.Write(matrix[i, j] + "\t");  
                }
                Console.WriteLine();
            }
            
            maxElement = matrix[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == maxElement)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            
            Console.WriteLine($"\nНаибольший элемент: {maxElement}");
            Console.WriteLine("\nПолученная матрица:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine(); 
            }
        }
    }
}