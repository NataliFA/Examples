// Вид 1
/*
void Method1();
{
    Console.Writeline("Автор...");
}
Method1();
*/
// Вид 2
/*
void Method2(string msg);
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");
*/
/*
void Method21(string msg1, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg1);
        i++;
    }
}
Method21("Текст", 4); //сколько раз хотим увидеть слово текст
*/

// Вид 3
/*
int Method3()
{
    return DateTime.Now.Year; // здесь что-то произошло
}
int year = Method3(); // сюда будет положен результат
Console.WriteLine(year); // вывод результата
*/

// Вид 4
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z"); 
Console.WriteLine(res);
*/

// цикл for (method 4)
/*
string Method4(int count, string text)
{
    string result = String.Empty; //пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z"); 
Console.WriteLine(res);
*/

// Классическая задача вывода цикла в цикле - таблица умножения
/*for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine(); // переъод на новую строку
}
*/

// Задача. Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.

/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "текст"
//            01234
// s[3] // c

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);
*/

//Задача. Алгоритм сортировки методом выбора (минимакса, максимального, минимального и тд)
// Упорядочить массив. Выбрать элемент и поменять с минимальным.

int[] arr = {1, 2, 5, 4, 3, 6, 1, 2, 5, 3};

void PrintArray (int[] array)
{

    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
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
