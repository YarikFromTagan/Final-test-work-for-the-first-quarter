/*
Написать программу, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше либо равна 3 символа.
*/

string[] InputArray(int num)
{
    string[] arr = new string[num];
    for(int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i+1} элемент ");
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
        Console.WriteLine("\b\b]");
        Console.WriteLine();
}

string[] ConversionArray(string[] inArr)
{
    int count = 0;
    for (int i = 0; i < inArr.Length; i++)
    {
        if (inArr[i].Length <= 3) count++;
    }
    
    string[] outArr = new string[count];

    count = 0;
    for (int i = 0; i < inArr.Length; i++)
    {
        if (inArr[i].Length <= 3)
        {
            outArr[count] = inArr[i];
            count++;
        }
    }
    return outArr;
}


Console.Clear();
Console.Write("Введите размерность массива, который Вы хотите создать N = ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = InputArray(n);

Console.WriteLine();
Console.Write("Вы создали массив: array ");
PrintArray(array);

string[] outArray = ConversionArray(array);

Console.WriteLine();
Console.Write("После выполнения поставленной задачи имеем: newArrray ");
PrintArray(outArray);