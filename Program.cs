Console.WriteLine("Введите строки через пробел:");
string input = Console.ReadLine();
string[] sourceArray = input.Split(' ');

int count = 0;
for (int i = 0; i < sourceArray.Length; i++)
{
    if (sourceArray[i].Length <= 3)
    {
        count++;
    }
}

string[] resultArray = new string[count];

int index = 0;
for (int i = 0; i < sourceArray.Length; i++)
{
    if (sourceArray[i].Length <= 3)
    {
        resultArray[index] = sourceArray[i];
        index++;
    }
}

Console.WriteLine("Массив строк меньше трёх символов:");
Console.WriteLine("[" + string.Join(", ", resultArray) + "]");