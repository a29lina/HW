

void Result(string[] array_1, string[] array_2)
{
    int count = 0;
    for (int i = 0; i < array_1.Length; i++)
    {
        if (array_1[i].Length <= 3)
        {
            array_2[count] = array_1[i];
            count++;
        }
    }
}


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}" + " ");
    }
}



Console.Write("Введите количество строк: ");

int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
string[] res = new string[size];

Console.WriteLine($"Введите {size} строк:");

for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine();
}

Result(array, res);
Console.Write($"Количество символов в строке меньше или равно {size}: ");
PrintArray(res);