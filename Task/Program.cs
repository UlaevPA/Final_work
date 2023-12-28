﻿/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] firstArray = { "Hello", "2", "World", ":-)" };

PrintArray(firstArray);
Console.WriteLine();
string[] secondArray = ReplaceString(firstArray);
PrintArray(secondArray);

string[] ReplaceString(string[] userString)
{
    string[] resultString = new string [userString.Length];
    for (int i = 0; i < userString.Length; i++)
    {
        if (userString[i].Length > 3) resultString[i] = "";
        else resultString[i] = userString[i];
    }
    return resultString;
}

void PrintArray(string[] array)
{
    foreach (var str in array) Console.Write($"{str} ");
}