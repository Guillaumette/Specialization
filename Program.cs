string[] CreateArray(int s)
{
    string[] array = new string[s];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void CreateNewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
        
}


Console.Write("Введите число элементов массива: ");
int size = int.Parse(Console.ReadLine());
string[] myArray = CreateArray(size);
string[] myArr = new string[myArray.Length];
System.Console.WriteLine();
System.Console.WriteLine("Вывод изначального массива:");
System.Console.WriteLine();
PrintArray(myArray);
System.Console.WriteLine();
CreateNewArray(myArray, myArr);
System.Console.WriteLine("Вывод итогового массива:");
System.Console.WriteLine();
PrintArray(myArr);