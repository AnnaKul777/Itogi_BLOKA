/* Написать программу, которая из имеющиегося массива строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно 
ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше
обойтись исключительно массивами. */

int ArrayThree(string[] text)                            // Задаем длину массива
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3) count++;
    }
    return count;
}

string[] Array(string[] text, int number)               // Заполнение массива
{
    string[] massiv = new string[number];
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
        {
            massiv[count] = text[i];
            count++;
        }
    }
    return massiv;
}

void PrintArray(string[] text)                           // Вывод на консоль
{
    for (int i = 0; i < text.Length; i++)
    {
        if (i < text.Length - 1)
            Console.Write($" {text[i]},");
        else
            Console.Write($" {text[i]}");
    }
}

