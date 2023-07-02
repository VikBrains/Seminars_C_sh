// Задача 11 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46, 782 -> 72


int number = new Random ().Next(100,1000);
Console.WriteLine($"Rundom integer: {number}");

Console.WriteLine((number / 100)*10 + (number % 10));

--------------------
// Задача. Сравнить цифры двузначного числа и вывести наибольшее и наименьшее

// int number = new Random().nextInt(10, 100);
// Console.WriteLine($"Random digit: {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
// {
    //Console.WriteLine($"Max digit in number is: {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Max digit in number is: {secondDigit}");
// }

// Console.WriteLine(number);