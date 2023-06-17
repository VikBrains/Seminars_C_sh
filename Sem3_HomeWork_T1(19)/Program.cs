// Задача 19: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// double number = GetTurn(number)
// int result = 0;
// while(number > 0)
//{
//    result = result*10;
//    result = result + number % 10;
//    number = number / 10;
//    return result;
//}


Console.Write("Input your number: ");
int number = int.Parse(Console.ReadLine());
int num_0 = number;

Console.WriteLine(num_0);


int result = 0;

while(number > 0)
{
    result = result*10;
    result = result + number % 10;
    number = number / 10;
}
Console.WriteLine(result);

if(num_0 == result)
{
    Console.WriteLine("yes, palindrome");
}
else
{
    Console.WriteLine("Not");
}
