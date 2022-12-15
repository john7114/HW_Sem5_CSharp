// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// 1. Создать метод для заполнения массива случайными числами
// 2. Создать метод находящий сумму элементов, стоящих на нечётных позициях
// 3. Инициализировать массив на размером 10 чисел
// 4. Применить методы и вывести сумму элементов на экран

// 1.
void FillArray(int[] arg)
{
    int len = arg.Length;
    for (int i = 0; i < len; i++)
    {
        arg[i] = new Random().Next(-100, 100);
    }
}

// 2.
int SumNumbers(int[] arg)
{
    int len = arg.Length;
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        if (i % 2 != 0) 
        {
            sum = sum + arg[i];
        }
    }
    return sum;
}

// 3.
int[] array = new int[10];

// 4.
FillArray(array);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
int result = SumNumbers(array);
Console.WriteLine(result);
