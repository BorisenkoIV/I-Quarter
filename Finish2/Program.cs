/*  Задача: 1-ая Четверть
 Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.Clear();
Console.WriteLine("  Задача: 1-ая Четверть");
Console.WriteLine("Ввод с клавиатуры строкового массива.");
Console.WriteLine("Вывод в консоль нового массива с длиной строк меньше четырех:");

// // Метод чтения даных с консоли:
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// Метод печати одноменрного массива:
void Print1Darr0(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.ResetColor();
    Console.WriteLine("]");
}

// Метод печати одноменрного массива:
void Print1Darr1(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.ResetColor();
    Console.WriteLine("]");
}


// Ввод строк с клавиатуры и образование нового массива:
string[] arr0; // ссылка на массив строк
int count; // текущее количество строк в массиве
string? str;
string[] arr1; // дополнительная переменная-ссылка - сохраняет старый массив строк

// Цикл ввода строк с клавиатуры:
Console.WriteLine("  Введите исходные строки:");
count = 0; // обнулить количество строк
arr0 = new string[count]; // выделить память для 0 строк
Console.ForegroundColor = ConsoleColor.Green;
do
{
    str = Console.ReadLine(); // ввести строку

    if (str != "")  // проверка, пустая ли строка
    {
        count++;  // если строка не пустая, то добавить строку в массив

        // выделить память для нового массива в котором на 1 элемент больше
        arr1 = new string[count];

        // скопировать старый массив в новый
        for (int i = 0; i < arr1.Length - 1; i++)
            arr1[i] = arr0[i];

        // добавить последнюю введенную строку в массив arr1
        arr1[count - 1] = str;

        arr0 = arr1; // перенаправить ссылку arr1 на arr0
    }
}
while (str != "");
Console.ResetColor();

// Метод очистки строк длинной больше 4х символов:
string[] Resul1Darr(string[] arr)
{
    //int ind=0;
    string[] arr2 = new string[arr0.Length];
    for (int i = 0; i < arr0.Length; i++)
    {
        str = arr0[i];
        if (str.Length <= 3)
            arr2[i] = arr0[i];
    }
    return arr2;
}

// Метод удаления элемента массива по индексу:
void RemoveArrInd(ref string[] arr, int index)
{
    string[] newArray = new string[arr.Length - 1];
    for (int i = 0; i < index; i++)
        newArray[i] = arr[i];
    for (int i = index + 1; i < arr.Length; i++)
    {
        newArray[i - 1] = arr[i];
    }
    arr = newArray;
}

// Метод удаления пустых строк:
string[] RemoveX(string[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        str = arr[i];
        if (str == null)
            RemoveArrInd(ref arr, i);
    }
    return arr;
}

Console.WriteLine("  Исходный массив:");
Print1Darr0(arr0); // исходный массив

Console.WriteLine("  Результирующий массив:");
string[] arr2 = Resul1Darr(arr0);

string[] arr = RemoveX(arr2);
Print1Darr1(arr); // результирующий массив
