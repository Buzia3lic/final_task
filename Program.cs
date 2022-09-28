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

Console.WriteLine("*********************************************************************************");
Console.WriteLine("Задача: Программа должна из имеющегося массива строк сформировать массив из строк,");
Console.WriteLine("длина которых меньше либо равна 3 символам");
Console.WriteLine("*********************************************************************************");

