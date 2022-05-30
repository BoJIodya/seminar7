// создеть двумерный массив
// спирально заполнить его:
// -сначала внешний периметр, затем внутренний и т.д.


int[,] FillArray(int[,] array)
{
    int i = array.GetLength(0);
    int j = array.GetLength(1);
    int s = 1;
    int q = 1;

    for (int y = 0; y < j; y++) //заполняет строчку 0,j (+)
    {
        array[0, y] = s;
        s++;
    }

    for (int y = 1; y < i; y++) // заполняет столбец 0,j (+)
    {
        array[y, j - 1] = s;
        s++;
    }
    {
        for (int x = j - 2; x >= 0; x--) //заполняет строчку i,j (+)
        {
            array[i - 1, x] = s;
            s++;
        }
    }
    for (int y = i - 2; y > 0; y--) // заполняет столбец 0,j (+)
    {
        array[y, 0] = s;
        s++;
    }                               // периметр заполнен

    array = FillArray1(array, q, s);
    return array;
}

int[,] FillArray1(int[,] array, int q, int s)
{
    int k = q, o = q;
    //Console.WriteLine(array[k, o+q]); // прверочная строка

    while (array[k, o + q] == 0) // движемся вправо
    {
        Console.WriteLine($"K = {k} O= {o} движемся вправо");
        array[k, o] = s;
        s++;
        o++;
    }

    while (array[k + q, o - q] == 0) // движемся вниз
    {
        Console.WriteLine($"K = {k} O= {o} движемся вниз");
        array[k, o] = s;
        s++;
        k++;
    }
    while (array[k, o - q] == 0) // движемся влево
    {
        Console.WriteLine($"K = {k} O= {o} движемся влево");
        array[k, o] = s;
        s++;
        o--;
    }

    while (array[k, o] == 0) // движемся вверх
    {
        Console.WriteLine($"K = {k} O= {o} движемся вверх");
        array[k, o] = s;
        s++;
        k--;
    }
    //q++;

    int step = array.GetLength(0) - 5;

    if (step >= 1)
    {
        k = q + 1; o = q + 1;
        Console.WriteLine($"K = {k} O= {o}"); // прверочная строка
        for (int a = 1; a < step - 1; a++)
        {
            q++;
            FillArray1(array, q, s);
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
                array[i, j] = s;
        }
    }
    return array;

}
void PrintArray(int[,] array) //печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }

}


int[,] array = new int[5, 5];
if (array.GetLength(0) != array.GetLength(1)) Console.WriteLine($"Введите параметры квадратной матрицы");
else
{
    array = FillArray(array);
    PrintArray(array);
}

