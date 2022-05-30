void RandomArray(int[,] array) //заполнение массива рандомно
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(int[,] array) //печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]:D2}");
        }
        Console.WriteLine();
    }

}

int GetMin(int[,] array)
{
    int min = array[0, 0];
    foreach (int number in array)
    {
        if (number < min) min = number;
    }
    return min;
}
(int, int) GetPosMinItem(int[,] Array, int min)
{
    int r = 0;
    int c = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (min == Array[i, j])
            {
                r = i;
                c = j;
            }
        }

    }
    return (r, c);
}
int[,] DeleteRowColum(int[,] array, int[,] array1, int r, int c)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != r && j != c)
            {
                if (i < r)
                {
                    if (j < c) array1[i, j] = array[i, j];
                    else array1[i, j - 1] = array[i, j];
                }
                else
                {
                    if (j < c) array1[i - 1, j] = array[i, j];
                    else array1[i - 1, j - 1] = array[i, j];
                }
            }
        }
    }

return array1;
}





int[,] array = new int[5, 5];
RandomArray(array);
PrintArray(array);

int min = GetMin(array);
Console.WriteLine(min);

(int r, int c) = GetPosMinItem(array, min);
Console.WriteLine($"r = {r}, c = {c}");
int[,] array1 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

array1 = DeleteRowColum(array, array1, r, c);
PrintArray(array1);
