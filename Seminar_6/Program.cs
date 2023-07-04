//
// Задание массива: array[i] = Math.Round((new Random().NextDoudle() * new Random().Next(0,10)), 2);

//

// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.

//Console.Write("Input first number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input second number: ");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.Write("Input third number: ");
//int c = Convert.ToInt32(Console.ReadLine());

//if (a >= b + c || b >= a + c || c >= b + a)
//{
//    Console.Write("That triangle can not be");
//}
//else Console.Write("This triangle can to be");

//

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101     3  -> 11     2  -> 10

//Console.Write("Input your number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//string word = " ";

//while (number > 0)
//{
//    if (number % 2 == 1)
//    {
//        word = 1 + word;
//    }
//    else
//    {
//        word = 0 + word;
//    }
//    number = number / 2;
//}
//Console.Write(word);

//

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3   //Если N = 3 -> 0 1 1   //Если N = 7 -> 0 1 1 2 3 5 8

//Console.Write("Input number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int a = 0;
//int b =1;

//Console.Write("0 1 ");
//for (int i = 2; i < number; i++)
//{
//    int result = a + b;
//    Console.Write(result + " ");
//    a = b;
//    b = result;
//}

//

//Задача 45: Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного копирования.

double[] array = new double[new Random().Next(11,21)];
Console.Write("recived array as ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");

Console.Write("Made array copy: ");
double[] arrayN = new double[array.Length];

for (int j = 0; j < array.Length; j++)
{
    arrayN[j] = array[j];
    Console.Write(arrayN[j] + " ");
}


// Переворот исходного массива
//int [] array = new int[10] { 1, 2, 3, -5, 7, -2, 9, 0, -3, 6};

//Console.Write("new array ");
//for(int i = 0; i < array.Length / 2; i++)
//{
//    int temp = array[i];
    //array[i] = array[(array.Length - 1) -i];
//    array[(array.Length - 1) - i] = temp;
//}
//for(int i = 0; i < array.Length; i++)
//{
//    Console.Write(array[i] + " ");
//}