Console.Clear();
int[] array = CreateArray(EnterLength());
ShowArray(array);
NumberSum();

int EnterLength()
{
    Console.Write("Enter your array's length:");
    int length = int.Parse(Console.ReadLine());
    return length;
}

void NumberSum()
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sum++;

    }

    Console.Write($"{sum}");
}

int[] CreateArray(int size)
{
    Console.WriteLine("Введите количество элементов массива");
    int[] massive = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        massive[i] = Convert.ToInt32(Console.ReadLine());
    }
    return massive;
}

void ShowArray(int[] array)
{

    Console.WriteLine($"[ {String.Join(", ", array)} ] => ");
}
