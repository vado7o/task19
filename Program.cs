﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Задача 19: программа проверяет является ли введённое пятизначное число палиндромом\n");

while(true) {
    Console.WriteLine("Введите целое ПЯТИЗНАЧНОЕ число:\n");
if(int.TryParse(Console.ReadLine(), out int number)) {
    if(Math.Abs(number) > 9999 && Math.Abs(number) < 100000) {
        Console.WriteLine(reverse(Math.Abs(number).ToString()));
        if(Math.Abs(number).ToString() == reverse(Math.Abs(number).ToString())) { Console.WriteLine("Да, введённое Вами число " + number + " является палиндромом!"); break;}
        else { Console.WriteLine("Нет, введённое Вами число " + number + " не является палиндромом!"); break; }
    } else Console.WriteLine("Введённое Вами число " + number + " НЕ является пятизначным!");
} else Console.WriteLine("Некорректно введено число!");
}

static string reverse (string str) {
char[] charArray = str.ToCharArray();
    Array.Reverse( charArray );
    return new String(charArray);
}