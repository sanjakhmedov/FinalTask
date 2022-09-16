﻿// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = { "Tashkent", "Ufa", "Osh", "Saint-Petersbourgh", "2U" };

string[] CheckArrLength(string[] arr)
{
    int count = 0;
    string[] newArr = new string[count];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[count] = arr[i];
            count++;
        }
        else continue;
    }
    return newArr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); // $"{Math.Round(array[i], 4)}, "
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

string[] newArray = CheckArrLength(array);
PrintArray(array);
PrintArray(newArray);