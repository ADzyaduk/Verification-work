// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] SearchForElements(string[] array, int stringLenght)
{
    string resultString = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= stringLenght) resultString += array[i] + " ";
    }
    string[] newArray = resultString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return newArray;
}

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string input = (Console.ReadLine()!);
string[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("Введите максимальную длинну элемента массива");
int stringLenght = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введенный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Новый массив: [{string.Join(", ", SearchForElements(array, stringLenght))}]");
