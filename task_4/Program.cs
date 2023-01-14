/*Задача 4*. Напишите программу, 
которая заполнит спирально массив 4 на 4.
Например, на выходе 
получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void FillArray(ref int[,] arr, int xEnd, int yEnd, int xStart = 0, int yStart = 1, int value = 1){
    if (value > arr.GetLength(1)*arr.GetLength(0)){
        Console.WriteLine("Массив заполнен");
    }else{
        
        int x = 0;
        int y = (yStart==1) ? 0 : yStart-1;
        xEnd = (xEnd==0) ? arr.GetLength(1) : xEnd;
        yEnd = (yEnd==0) ? arr.GetLength(0) : yEnd;
        
        for (int i = xStart; i < xEnd; i++) // заполнить строку слева направо 
        {
            x = i;
            arr[y,x] = value;
            value++;
        }
        xEnd--;

        for (int j = yStart; j < yEnd; j++) // заполнить столбец сверху вниз 
        {
            y = j;
            arr[y,x] = value;
            value++;
        }
        yEnd--;

        for (int i = xEnd-1; i >= xStart; i--) // заполнить строку справа налево 
        {
            x = i;
            arr[y,x] = value;
            value++;
        }
        xStart++;
        
        for (int j = yEnd-1; j >= yStart ; j--) // заполнить столбец снизу вверх 
        {
            y = j;
            arr[y,x] = value;
            value++;
        }
        yStart++;

        FillArray(ref arr, xEnd, yEnd, xStart, yStart, value);

    }
}

void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }   
}

int [,] myArray = new int[6,6];

FillArray(ref myArray, 0, 0);

PrintArray(myArray);

