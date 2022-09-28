string[] GetArrey(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите слово {i + 1} для запеси в массив: ");
        result[i] = Console.ReadLine();
    }
    return result;
}

void PrintArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int CountString(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

string[] TaskArray(string[] arr, int count)
{
    string[] result = new string[count];
    count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[count] = arr[i];
            count++;
        }
    }
    return result;
}

Console.WriteLine("*********************************************************************************");
Console.WriteLine("Задача: Программа должна из имеющегося массива строк сформировать массив из строк,");
Console.WriteLine("длина которых меньше либо равна 3 символам");
Console.WriteLine("*********************************************************************************");

