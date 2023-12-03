// То что закомиченно двойным слешем // Не раскомичивать Никогда.
// То что закомиченно слешем со /* и */  раскомичивать, удаляя только первый /* либо удаляя Таб перед ним:
// 1 Вид методов: 
/*
void Method1 ()
{
    Console.WriteLine("Автор ...");
}

Method1 ();
// */

//  2 Вид методов: 
/*
void Method2 (string msg, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
  
}
Method2 (msg: "Тест.", count: 4);
Method2 (count: 5, msg: "Тест новый.");   // Это "именованые аргументы" - их не обязательно писать по порядку.
// */

//  3 Вид методов: 
/*
int Method3 ()
{
    return DateTime.Now.Year;
}
Console.Write (Method3());
// */

//  4 Вид методов: 
/*
string Method4 (int count, string text)
{
    string result = String.Empty;  // string result = "";
    for (int i=0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4 (7, "Некий текст. ");
Console.Write(res);
// */

//  Цикл в цикле! 
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
// */

//  Работа с текстом!
//  Теория:
//  string s = "qwerty" - если дан такой текст, то
//              012345  - это индексы символов в нём,
//  s[3] это "r"        - ес написать s[3], то символ в переменной "s" c инедксом "3" имеет значение "r"

//  Задача.  Дан текст. Заменить все пробелы чёрточками, маленькие буквы "к" заменить большими "К", 
//  а большие буквы "С" заменить маленькими "с".
//  (удалить табуляцию здесь-ниже, чтобы раскомитить всю задачу): 
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие русского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace (text, ' ', '|'); 
// объявляется предварительная переменная. Она нужна чтобы полученный текст не только был напечатан,
// но и сохранить его в переменную, для дальней работы с ним, но уже с внесёнными изменениями.
Console.WriteLine(newText);
Console.WriteLine();  // пустая строка для красоты.
Console.WriteLine(Replace(newText, 'к', 'К'));
Console.WriteLine();  // пустая строка для красоты.
Console.WriteLine(Replace(newText, 'о', 'А'));           // */

//  ЗАДАЧА ПО СОРТИРОВКЕ МАССИВА!!!  
/*  
int[] arr = {7, 4, 3, 8, 2, 6, 8, 5, 7, 9, 1, 3, 5, 4};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)  Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
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
*/