// Напишите программу, которая принимает на вход координаты точки (X и Y)
// причём (X !=0) и (Y !=0) и выдаёт номер четверти плоскости, в которой находится эта точка

// Console.WriteLine(Math.Pow(2, 5));

// ! организация Своего Метода (даём название (напр, GetSum(ниже))и 
//   загоняем в фигурные скобки типовое решение типовой задачи)

int GetSum(int number_a, int number_b)
{
    int result = number_a + number_b;
    return result;
    //return (number_a + number_b);
}

void PrintMessageToConsole(string message)
{
    Console.WriteLine(message);
}
Console.WriteLine("Start");

int a = 10;
int b = 20;

int sum = GetSum(a, b);
Console.WriteLine(sum);

PrintMessageToConsole("Hello, World!");