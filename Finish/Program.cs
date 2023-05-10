/* Задача: 1-ая Четверть
 Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 */

Console.Clear();
Console.WriteLine("  Задача: 1-ая Четверть");
Console.WriteLine("  Ввод с клавиатуры строкового массива:");


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
void Print1Darr2(string[] arr)
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

// Цикл ввода строк
Console.WriteLine("Введите исходные строки:");

count = 0; // обнулить количество строк
arr0 = new string[count]; // выделить память для 0 строк

do
{
    str = Console.ReadLine(); // Ввести строку

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

        arr0 = arr1; // перенаправить ссылку arr0 на arr1
    }
} while (str != "");




// // Метод копирования массива:
// string[] Copy1Darr(string[] arr)
// {
//     string[] res = new string[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         res[i] = arr[i];
//     }
//     return res;
// }

string[] Copy1Darr(string[] arr)
{
string[] arr2 = new string[arr0.Length];
for (int i = 0; i < arr0.Length; i++)
{
    str = arr0[i];
    if (str.Length <= 3)
    {
        arr2[i] = arr0[i];
    }
    else
    {
        arr2[i] = " ";
    }

}
return arr2;
}


Console.WriteLine("  Исходный массив:");
Print1Darr0(arr0);
Console.WriteLine("\n  Результирующий массив:");
//Print1Darr1(arr0);

string[] arr2 = Copy1Darr(arr0); // создание копии исходного массива
Print1Darr2(arr2);



// // Метод генерации строкового массива:
// void StrArr(int n)
// {
//   //     string[] s = new string[5];
//     //int n;
//     // Console.WriteLine("Введите кол-во строк :");
//     // n = int.Parse(Console.ReadLine());
//     for (int i = 0; i < n; i++)
//     {
//         s[i] = Console.ReadLine();
//     }
//     Console.WriteLine("Результирующий массив: ");
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write(s[i] + ", ");
//     }
//     Console.ReadLine();
//     // Console.ReadKey();
// }
// // }

// // int N = ReadData("Введите количество элементов в строковом массиве: ");
// // StrArr(N);





// string str = @"мама мыла раму";
// char [] ar = str.ToCharArray();
// Console.WriteLine(ar[1]);


// string str = @"мас i сив";
// char [] ar = new char [str.Length];
// for(int i = 0; i < str.Length; i++)
// {
// ar[i] = str[i];
// Console.WriteLine(ar[i]);
// }


// // Преобразовать массив в строку
// string str = string.Join("\r\n", array);