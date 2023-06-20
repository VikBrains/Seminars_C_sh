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

//.if (number < 0)
//.{
//.    Console.Write("you num Not palindrom");
//.}

//.string number_str = number.ToString();
//.if (number_str[0] == number_str[4] && number_str[1] == number_str[3])
//.{
//.    Console.Write("your num is palindrom");
//.}
//.else
//.{
//.    Console.Write("your num not palindrom");
//.}


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
