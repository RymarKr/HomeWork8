/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.WriteLine("введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int number = 0;
int range = InputNumbers(number);
int[,] array = new int[m, n];
CreateRandomArray(array);
WriteArray(array);
Console.WriteLine("Упорядоченный массив по убыванию элемента каждой строки: ");
OrderedArray(array);
WriteArray(array);

void OrderedArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(0) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int arr = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = arr;
        }
      }
    }
  }
}

int InputNumbers(int number)
{
Console.Write("Кол-во элементов в массиве: ");
int output = int.Parse(Console.ReadLine());
return output;
}

void CreateRandomArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}