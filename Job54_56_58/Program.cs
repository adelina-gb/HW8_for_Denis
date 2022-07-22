void FillArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


void Zadacha54()
{
    /*
    Задача 54: Задайте двумерный массив. Напишите программу, 
    которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    1 2 4 7
    2 3 5 9
    2 4 4 8
    */

    Random random = new Random();
    int rows = random.Next(3, 6);
    int columns = random.Next(3, 6);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("Массив, в котором элементы отсорированы по убыванию");
    SortingMax(array);
    PrintArray(array);


}

void SortingMax(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for(int k = 0; k < columns - 1; k++)
            {
                int max = array[i, k];
                if(array[i,k+1] > max)
                {
                    max = array[i, k+1];
                    array[i, k+1] = array[i, k];
                    array[i, k] = max;
                }
            }
        }
    }
}

void Zadacha56()
{
    /*
    Задача 56: Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

    Random random = new Random();
    int rows = random.Next(4,5);
    int columns = random.Next(3,4);
    int[,] array = new int[rows,columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    SumRowsElenments(array);
}

void SumRowsElenments(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    int sumMin = 0;
    int sumMinIndex = 0;

    for (int j = 0; j < columns; j++)
    {
        sumMin += array[0,j];
    }   
    Console.WriteLine($"Суммa 1 строка {sumMin}");  
        
    for (int i = 1; i < rows; i++)
    {
        int sum = 0;
        for(int j = 0; j < columns; j++)
        {
            sum += array[i,j];
        }
        Console.WriteLine($"Сумма {i + 1} строки равна {sum}");

        if(sum < sumMin)
        {
            sumMin = sum;
            sumMinIndex = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма находится в строке {sumMinIndex + 1}  и равна {sumMin}");
    

}

Zadacha54();
//Zadacha56();