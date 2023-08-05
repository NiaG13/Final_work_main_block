// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Main();

void Main()
{
    bool work = true;
    while(work)
    {
        System.Console.WriteLine("Hello! Run the program? y/n");
        string a = Console.ReadLine();
        switch(a)
        {
            case "y": Task(); break;
            case "n": work = false; break;
            default: break;
        }
    }
    System.Console.WriteLine("Have a good time!");
}

void Task()
{
    int max_length_value = 3;
    int max_lenght_array = 10;
    int length_array = ReadIntLength("an original array length (from '0' to '9')", max_lenght_array);
    string[] original_array = FillArray(length_array);
    PrintArray(original_array, "Original array");
    int count_values = CountValues(original_array, max_length_value);
    string[] filtered_array = new string[count_values];
    if(count_values != 0)
    {
        filtered_array = FilteringArray(original_array, max_length_value, filtered_array);
    }
    PrintArray(filtered_array, "Filtered array");
}

int ReadIntLength(string argument, int max)
{
    int number;
    System.Console.WriteLine($"Enter {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > max)
    {
        System.Console.WriteLine("It's not that!");
    }
    return number;
}

string[] FillArray (int length_array)
{
    string[] array = new string[length_array];
    System.Console.WriteLine($"Enter {length_array} elements from a new line:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array, string message)
{
    System.Console.Write($"{message}: [");
    if (array.Length !=0)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write("\"");
            System.Console.Write(array[i]);
            System.Console.Write("\", ");
        }
        System.Console.Write($"\"{array[array.Length - 1]}\"");
    }
    System.Console.WriteLine("]");
}

int CountValues(string[] array, int max_lim)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= max_lim)
        {
            count ++;
        }
    }
    return count;
}

string[] FilteringArray(string[] array, int max_lim, string[] output_array)
{
    int index_filter_value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= max_lim)
        {
            output_array[index_filter_value] = array[i];
            index_filter_value ++;
        }
    }
    return output_array;
}