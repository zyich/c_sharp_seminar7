/* 
Задача 51: Задайте двумерный массив. Найдите
 элементы, у которых оба индекса 
 чётные, и замените эти элементы 
 на их квадраты. 
Например, задан массив: 
1 4 7 2 
5 9 2 3 
8 4 2 4 
Сумма элементов главной диагонали: 1+9+2 = 12 
*/ 
 
int [,] CreateArray(int row, int col, int min, int max){ 
    Random rand = new Random(); 
    int [,] array = new int [row,col]; 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
            array[i,j] = rand.Next(min,max+1); 
    } 
    return array; 
} 
 
int [,] ChangeArray(int [,] array){ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            if(i%2==0 && j%2==0){ 
                array[i,j] = (int)Math.Pow(array[i,j],2); 
            } 
        } 
    } 
    return array; 
} 
 
int SumDiagonalArray(int [,] array){ 
    int sumDiagonal = 0; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            if(i==j){ 
                sumDiagonal+=array[i,j]; 
            } 
        } 
    } 
    return sumDiagonal; 
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
int [,] array = CreateArray(3,4,0,10); 
PrintArray(array); 
Console.WriteLine(); 
int sum = SumDiagonalArray(array); 
Console.WriteLine($"Sum of elements in diagonal in array is {sum}"); 
Console.WriteLine(); 
array = ChangeArray(array); 
PrintArray(array); 
sum = SumDiagonalArray(array); 
Console.WriteLine($"Sum of elements in diagonal in array is {sum}");