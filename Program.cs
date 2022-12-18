int[] RandomNumbers(int size, int leftRange, int rightRange)
{
    int[] tempArr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArr;
}

double[] DoubleRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] tempArr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3); 
    }
    return tempArr;
}


int rep = 0;
while (rep == 0)
{
    Console.WriteLine("Выберите номер задания \n 1. Кол-во чётных чисел в массиве \n 2. Сумма эл-тов на нечётных позициях \n 3. Разность максимального и минимального эл-та массива \n 0. Выход");
    Console.Write("Ввод: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n == 1)
    {
        int[] arr = RandomNumbers(8, 100, 1000);
        System.Console.WriteLine($"[ {string.Join(", ", arr)} ]");
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count += 1;
            }
        }
        System.Console.WriteLine($"Кол-во положительных чисел в массиве: {count}");

        Console.WriteLine("____________");
    }
    else if (n == 2)
    {
        int[] arr2 = RandomNumbers(8, 0, 10);
        System.Console.WriteLine($"[ {string.Join(", ", arr2)} ]");
        int summ = 0;

        for (int i = 1; i < arr2.Length; i = i + 2)
        {
            summ += arr2[i];
        }
        System.Console.WriteLine($"Сумма эл-тов на нечётных позициях: {summ}");

        Console.WriteLine("____________");
    }
    else if (n == 3)
    {
        double[] arr3 = DoubleRandomNumbers(8, 0, 10);
        System.Console.WriteLine($"[ {string.Join("; ", arr3)} ]");

        double max = arr3[0];
        for (int i = 1; i < arr3.Length; i++)
        {
            if (arr3[i] > max)
            {
                max = arr3[i];
            }
        }

        double min = arr3[0];
        for (int i = 1; i < arr3.Length; i++)
        {
            if (arr3[i] < min)
            {
                min = arr3[i];
            }
        }

        System.Console.WriteLine($"Разность максимального {max} и минимального {min}:  {Math.Round(max - min, 3)}");

        Console.WriteLine("____________");
    }
    else if (n == 0)
    {
        Console.WriteLine("You kill me :c");
        break;
    }
    else
    {
        rep = 0;
    }

    await Task.Delay(2000);
}