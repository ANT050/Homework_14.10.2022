/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int GetValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void PrintMyArray(double[] myArray)
{
    Console.Write("Случайные числа массива: ");

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]}");
        if (i != myArray.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine();
}

double[] InitMyArray(int value)
{
    double[] myArray = new double[value];
    Random rnd = new Random();

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = Math.Round(rnd.Next(-10, 11) + rnd.NextDouble(), 2);
    }

    return myArray;
}

//Первое значение максимальный элемент, второе - минималный
(double, double) GetMaxMin(double[] myArray)
{
    double resultMax = myArray[0];
    double resultMin = myArray[0];

    for (int i = 1; i < myArray.Length; i++)
    {
        if (resultMax < myArray[i])
            resultMax = myArray[i];

        if (resultMin > myArray[i])
            resultMin = myArray[i];
    }

    return (resultMax, resultMin);
}

double DifferenceBetweenMaxMin(double max, double min)
{
    double resultDifference = Math.Round((max - min), 2);
    return resultDifference;
}

int value = GetValue("\nВведите необходимое количество чисел в массиве: ");
double[] array = InitMyArray(value);
PrintMyArray(array);

(double max, double min) = GetMaxMin(array);
double difference = DifferenceBetweenMaxMin(max, min);

Console.WriteLine($"\nМаксимальный элемент: {max}");
Console.WriteLine($"Максимальный элемент: {min}\n");
Console.WriteLine($"Разница между MAX и MIN значениями массива: {difference}\n");
