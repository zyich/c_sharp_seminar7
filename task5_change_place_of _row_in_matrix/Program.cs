/* 
Задача 53: Задайте двумерный массив.
Напишите программу, которая 
поменяет местами первую и 
последнюю строку массива. 
 
Например, задан массив: 
1 4 7 2 
5 9 2 3 
8 4 2 4 
 
В итоге получается вот такой массив: 
8 4 2 4 
5 9 2 3 
1 4 7 2 
*/ 
 
int [,] CreateArray(int row, int col, int min, int max){ 
    Random rand = new Random(); 
    int [,] array = new int [row,col]; 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            array[i,j] = rand.Next(min,max+1); 
        } 
    } 
    return array; 
} 
 
int [,] ChangeRows(int [,] array){ 
    int temp = 0; 
    for (int j = 0; j < array.GetLength(1); j++) 
        { 
            temp = array[array.GetLength(0)-1,j]; 
            array[array.GetLength(0)-1,j] = array[0,j]; 
            array[0,j] = temp; 
        } 
    return array; 
} 
 
void PrintArray(int [,] array){ 
    int row = array.GetLength(0); 
    int col = array.GetLength(1); 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            Console.Write($"{array [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
} 


Console.Clear(); 
int [,] array = CreateArray(4,4,0,100); 
PrintArray(array); 
Console.WriteLine(); 
array = ChangeRows(array); 
PrintArray(array);
