// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5,    78 -> третьей цифры нет,   32679 -> 6

Console.Write("Input your integer: ");
int num_a = int.Parse(Console.ReadLine());
int num_c = num_a;

int count = 0;
while (num_a != 0)
{
    num_a = num_a / 10;
    count++;
}

if (count >= 3)
{
    int num_e = (num_c /(int)Math.Pow(10,count - 3)) % 10;
    Console.WriteLine($"third digit of integer: {Math.Abs(num_e)}");
}
else
{
    Console.WriteLine("third digit absent");
}
