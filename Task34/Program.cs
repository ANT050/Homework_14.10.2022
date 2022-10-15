/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


/*ПЕРВЫЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ*/

int GetValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void PrintMyArray(int[] myArray)
{
    Console.Write("Случайные положительные трехзначные числа: ");

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
        myArray[i] = rnd.Next(100, 1000);
    }

    return myArray;
}

int EvenInteger(int[] myArray)
{
    /*int number = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0)
            number++;
    }*/
    int number = myArray.Count(i => i % 2 == 0 && i > myArray.Length);
    return number;
}

int value = GetValue("\nВведите необходимое количество чисел в массиве: ");
int[] array = InitMyArray(value);
PrintMyArray(array);

int even = EvenInteger(array);
Console.WriteLine($"\nКоличество четных чисел в массиве: {even}\n");

/*ВТОРОЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ*/

/*

Console.WriteLine(" ");
Console.Write("Введите необходимое количество чисел в массиве: ");
var value = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[value];
Random rnd = new Random();
int number = 0;

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(100, 1000);

    if (myArray[i] % 2 == 0)
    {
        number = number + 1;
    }
}
Console.WriteLine($"Случайные положительные трехзначные числа: {String.Join(", ", new List<int>(myArray).ConvertAll(i => i.ToString()).ToArray())}\n");
Console.WriteLine($"Количество четных чисел в массиве:  {number}\n");

*/
