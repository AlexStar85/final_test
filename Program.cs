// Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.



// Запрос у пользователя количества строк для исходного массива
Console.Write("Введите количество строк: ");
int numberOfStrings = Convert.ToInt32(Console.ReadLine());

// Инициализация исходного массива строк
string[] initialArray = new string[numberOfStrings];

// Заполнение исходного массива строками, введенными пользователем
for (int i = 0; i < numberOfStrings; i++)
{
    Console.Write($"Введите строку номер {i + 1}: ");
    initialArray[i] = Console.ReadLine();
}

// Подсчет количества строк, удовлетворяющих условию (длина <= 3)
int count = 0;
foreach (string str in initialArray)
{
    if (str.Length <= 3)
    {
        count++;
    }
}

// Создание нового массива для строк, удовлетворяющих условию
string[] resultArray = new string[count];

// Заполнение нового массива подходящими строками
int index = 0;
foreach (string str in initialArray)
{
    if (str.Length <= 3)
    {
        resultArray[index] = str;
        index++;
    }
}

// Вывод нового массива строк
Console.WriteLine("Новый массив строк, длина которых меньше или равна 3 символам:");
foreach (string str in resultArray)
{
    Console.WriteLine(str);
}

