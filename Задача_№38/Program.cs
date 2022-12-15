// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.3 7.76 22 2 78.67] -> 76.67

// 1. Cоздать метод, заполнящий массив вещественными числами
// 2. Создать метод, находящий минимальный по значению элемет массива
// 3. Создать метод, находящий максимальный элемент массива
// 4. Инициализировать массив размером на 10 чисел
// 5. Применить все три созданные методы по порядку: заполнить массив, найти максимальное и минимальное число
// 6. Вычесть из максимального элемента, минимальный элемент и вывести разность на экран

// 1.
void FillArray(double[] arg)
{
    int len = arg.Length;
    for (int i = 0; i < len; i++)
    {
        Random x = new Random();
        arg[i] = Convert.ToDouble(x.Next(1000) / 10.0);
    }
}

// 2.
double MaxElementValue(double[] arg)
{
    int len = arg.Length;
    double max = arg[0];
    for (int i = 1; i < len; i++)
    {
        if (max < arg[i])
        {
            max = arg[i];
        }
    }
    return max;
}

// 3.
double MinElementValue(double[] arg)
{
    int len = arg.Length;
    double min = arg[0];
    for (int i = 1; i < len; i++)
    {
        if (min > arg[i])
        {
            min = arg[i];
        }
    }
    return min;
}

// 4.
double[] array = new double[8];

// 5.
FillArray(array);
double max_element = MaxElementValue(array);
double min_element = MinElementValue(array);

// 6.
double residual = max_element - min_element;
Console.WriteLine(residual);