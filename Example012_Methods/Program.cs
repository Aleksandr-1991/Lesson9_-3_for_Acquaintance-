using System;
// 1 вид методов:
// void Method1 ()
// {
//     Console.WriteLine("Автор ...");
// }

// Method1 ();

// 2 вид методов:
// void Method2 (string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2 ("Тест сообщения.");

// void Method21 (string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21 (msg: "Тест.", count: 5);
// Method21 (count: 5, msg: "Тест новый.");

// 3 вид методов:
// int Method3 ()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// // 4 Вид методов:
// string Method4 (int count, string text)
// {   int i=0;
//     string result = String.Empty;
//     while (i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4 (10, "Некий текст. ");
// Console.WriteLine(res);

// 4 Вид методов ч/з метод  for:
// string Method4 (int count, string text)
// {
//     string result = String.Empty;
//     for (int i=0; i<count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4 (10, "Некий текст. ");
// Console.WriteLine(res);
// // Цикл в цикле:
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Работа с текстом.   Дан текст. Внём нужно заменить все пробелы чёрточками,
// маленькие буквы "к" заменить большими "К",
// а большие буквы "С" заменить маленькими "с".
// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие русского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// // string s = "qwerty"
// //             012345
// // s[3] это "r"

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// // string newText = Replace (text, ' ', '|');
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'о', 'А');
// Console.WriteLine(newText);

// ЗАДАЧА ПО СОРТИРОВКЕ МАССИВА!!!
int[] arr = {7, 4, 3, 8, 2, 6, 8, 5, 7, 9, 1, 3, 5, 4};


void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);