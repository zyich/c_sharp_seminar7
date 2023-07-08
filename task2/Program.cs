/*
Задача 48: Задайте двумерный массив 
размера m на n, каждый элемент
 в массиве находится
  по формуле: Aₘₙ = m+n. Выведите полученный 
  массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/



Console.Clear();


int [,] CreateArray(int m, int n)
{
    Random rand = new Random();
    int [,] array = new int [n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }


}

int [,] array = CreateArray(4,3);
PrintArray(array);