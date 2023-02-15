//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов массива: ");
// int columns=int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// SortArray(array);
// Console.WriteLine();
// Printarray(array);


// // ------------------м--------------

// void SortArray (int [,] array)
// {
//     for (int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//             for (int t = j+1; t<array.GetLength(1);t++)
//             {
//                 if (array[i,t]>array[i,j])
//                 {
//                   int temp = array[i,j];
//                   array[i,j]=array[i,t];
//                   array[i,t] = temp;
//                 }
//             }
//         }
//     }
// }


//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

 Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

//--------------------Метод------------------------------------------------------
Console.WriteLine($"Строка с маленькой суммой - {GetRowNumbers(array)}");

int GetRowNumbers (int [,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i<array.GetLength(1); i++)
    {
        minsum = minsum + array[0,1];
    }

    for (int i = 1; i<array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j<array.GetLength(1); j++)
        {
            sum = sum+array[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}
