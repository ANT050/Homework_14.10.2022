/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

/*ПЕРВЫЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ*/

int GetValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void PrintMyArray(int[] myArray)
{
    Console.Write("Случайные числа массива: ");

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i]);
        if (i != myArray.Length - 1)
            Console.Write(", ");
    }

    Console.WriteLine();
}

int[] InitMyArray(int value)
{
    int[] myArray = new int[value];
    Random rnd = new Random();

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(-100, 101);
    }

    return myArray;
}

int SumOfOddElements(int[] myArray)
{
    int number = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            number += myArray[i];
        }
    }

    return number;
}

int value = GetValue("\nВведите необходимое количество чисел в массиве: ");
int[] array = InitMyArray(value);
PrintMyArray(array);

int even = SumOfOddElements(array);
Console.WriteLine($"\nСумма элементов на нечётных позициях: {even}\n");

/* ВТОРОЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ*/

/*

Console.WriteLine(" ");
Console.Write("Введите необходимое количество чисел в массиве: ");
var value = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[value];
Random rnd = new Random();
int number = 0;

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(-100, 101);

    if (i % 2 != 0)
    {
        number += myArray[i];
    }
}
Console.WriteLine($"Случайные числа массива: {String.Join(", ", new List<int>(myArray).ConvertAll(i => i.ToString()).ToArray())}\n");
Console.WriteLine($"Сумма элементов на нечётных позициях:  {number}\n");

*/