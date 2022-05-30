// сщздать трехмерный массив
//заполнить двузначными неповторяющимися числами
// показать его построчно на экран выводя индексы соответствующего элемента

void RandomArray(int[,,] array) //заполнение массива рандомно
{
    int number = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLongLength(2); n++)
            {

                array[i, j, n] = number;
                number++;
            }
        }
    }
}

void PrintArray(int[,,] array) //печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLongLength(2); n++)
            {
                Console.Write($" i = {i}, j = {j}, n = {n} number = {array[i, j, n]};");

            }
        }
        Console.WriteLine();
    }

}

int[,,] array = new int[3, 3, 3];
RandomArray(array);
PrintArray(array);
