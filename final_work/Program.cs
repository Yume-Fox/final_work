// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] GetArrayStringsLessThanThreeLetters(string[] array)
{
    int size = array.Length;
    int count = 0;
    string[] tempArray;

    for (int i = 0; i < size; i++)
    {
        if (CheckArrayToStringsLessThanThreeLetters(array, i))
        {
            count++; 
        }
    }

    tempArray = new string[count];

    for(int i = 0, j = 0; i < size; i++)
    {
        if (CheckArrayToStringsLessThanThreeLetters(array, i))
        {
            tempArray[j] = array[i];
            j++; 
        }
    }

    return tempArray;
}

bool CheckArrayToStringsLessThanThreeLetters(string[] array, int index)
{
    if (array[index] != null && array[index].Length <= 3 && array[index].Length > 0)
    {
        return true;
    }
    return false;
}

void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[\"{array[i]}\"]");
    }
    Console.WriteLine();
}


Console.Write("Исходный массив: ");
string[] stringArray = {"kolbasa", "2648", "sort by sort", "4", "6549875", "mangust", "do u like?", "CodeWar", "777", "8312", "64", "cat"};
printArray(stringArray);
Console.WriteLine();

string[] targetArray = GetArrayStringsLessThanThreeLetters(stringArray);
Console.Write("Массив после обработки: ");
printArray(targetArray);
Console.WriteLine();
