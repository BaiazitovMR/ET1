﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделенные запятой:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        string[] newArray = FilterArray(inputArray);

        Console.WriteLine("Новый массив:");
        foreach (string item in newArray)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }

    static string[] FilterArray(string[] inputArray)
    {
        int count = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                newArray[index] = item;
                index++;
            }
        }

        return newArray;
    }
}