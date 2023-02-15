//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SortArray(array);
Console.WriteLine();
Printarray(array);


// ------------------м--------------

void SortArray (int [,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            for (int t = j+1; t<array.GetLength(1);t++)
            {
                if (array[i,t]>array[i,j])
                {
                  int temp = array[i,j];
                  array[i,j]=array[i,t];
                  array[i,t] = temp;
                }
            }
        }
    }
}
