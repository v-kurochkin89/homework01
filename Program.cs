Console.WriteLine("Введите строки через пробел:");
string input = Console.ReadLine(); // Ввод строк
string[] sourceArray = input.Split(' '); // Преобразование в массив с разделителем пробел

// Считаем количество строк с символами меньше трёх
int count = 0;
for (int i = 0; i < sourceArray.Length; i++)
{
    if (sourceArray[i].Length <= 3)
    {
        count++;
    }
}

// Создаём новый массив из такого количества строк, которое подсчитано ранее
string[] resultArray = new string[count];

// Добавляем подходящие строки в созданный массив
int index = 0;
for (int i = 0; i < sourceArray.Length; i++)
{
    if (sourceArray[i].Length <= 3)
    {
        resultArray[index] = sourceArray[i];
        index++;
    }
}

// Выводим массив в нужном формате
Console.WriteLine("Массив строк меньше трёх символов:");
Console.WriteLine("[" + string.Join(", ", resultArray) + "]");