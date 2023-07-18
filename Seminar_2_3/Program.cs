// Задача.  развернуть число

// int number = int.Parse(Console.ReadLine());
// int result = 0;

// while(number > 0)
// {
//    result = result*10;
//     result = result + number % 10;
//     number = number / 10;
// }
// Console.WriteLine(result);


// -- разворот числа 2
// Console.Write("Input nimber: ");
// int num_a = int.Parse(Console.ReadLine());
// int num_b = 0;

// while (num_a != 0)
// {
//    num_b = num_a % 10;
//    num_a = num_a / 10;
//    Console.Write(num_b);
// }

// ------

// Задача. Принимается число любой размерности. Вывести количество цифр в этом  числе. Только While

Console.Write("Input nimber: ");
int num_a = int.Parse(Console.ReadLine());
int num_b = 0;

int count = 0;
while (num_a != 0)
{
    num_a = num_a / 10;
    count++;
}
Console.Write(count);

