Console.WriteLine("Введите количество элементов массива");
int firstArraySize = Convert.ToInt32(Console.ReadLine());

string[] FirstArray(int num)
{
    string[] array = new string[num];
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] firstArray = FirstArray(firstArraySize);

string[] StringSelection(string[] array)
{
    int count = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        count++;
    }
    
    string[] newArray = new string[count];

    for(int i = 0, k = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
} 

string[] myArray = StringSelection(firstArray);

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(" \n");
}

Console.Write("Первый массив: ");
ShowArray(firstArray);

Console.Write("Элементы менее трех символов: ");
ShowArray(myArray);
