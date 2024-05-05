// Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.



// Метод для ввода строк в массив с клавиатуры
string[] EnterStringsToArray()
{
    Console.WriteLine("Введите количество строк: ");
    int count = int.Parse(Console.ReadLine()); // Считывание количества строк

    string[] workArray = new string[count]; // Инициализация массива строк

    // Запрос строк у пользователя
    Console.WriteLine($"Введите {count} строк(у) (после ввода каждой нажмите ENTER):");
    for (int i = 0; i < count; i++)
    {
        workArray[i] = Console.ReadLine(); // Сохранение каждой введенной строки в массив
    }

    return workArray; // Возврат заполненного массива
}

// Метод для создания нового массива из строк, длина которых меньше или равна 3 символам
string[] CreatingArrayStringsLessThan3(string[] workArray)
{
    int count = 0; // Счетчик для подсчета строк подходящей длины
    // Подсчет количества строк подходящей длины
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count]; // Создание нового массива для подходящих строк
    int i = 0; // Индекс для нового массива
    // Заполнение нового массива строками подходящей длины
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            result[i] = item;
            i++;
        }
    }

    return result; // Возврат нового отфильтрованного массива
}

// Метод для преобразования массива строк в строку для печати
string PrintArray(string[] workArray)
{
    string arString = "["; // Начало строки для печати
    // Проход по всем элементам массива
    for (int i = 0; i < workArray.Length; i++)
    {
        arString += $""{workArray[i]}""; // Добавление элемента массива в строку
        if (i < workArray.Length - 1)
        {
            arString += ", "; // Добавление запятой между элементами
        }
    }
    arString += "]"; // Закрытие строки для печати
    return arString; // Возврат строки для печати
}

// Основной код программы
string[] workArray = EnterStringsToArray(); // Ввод массива строк пользователем
string[] result = CreatingArrayStringsLessThan3(workArray); // Создание отфильтрованного массива
string firstArray = PrintArray(workArray); // Преобразование исходного массива в строку для печати
string secondArray = PrintArray(result); // Преобразование отфильтрованного массива в строку для печати

// Вывод исходного и отфильтрованного массивов
Console.WriteLine(firstArray + " -> " + secondArray);
