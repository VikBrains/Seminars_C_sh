// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


//Console.Write("Input your number: ");
//int num = int.Parse(Console.ReadLine());

//int[] array = new int[8];
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = new Random().Next(0, 10);
//    Console.WriteLine($" {array[i]}");
//}

//bool isFound = false;

//for (int i = 0; i < array.Length; i++)
//{
//    if (num == array[i])
//    {
//        isFound = true;
//        break;
//    }
//}
//Console.WriteLine((isFound ? "yes" : "no"));

//Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


//int [] array = new int [4] {-15, 48, -8, 12};


//for (int i = 0; i < array.Length; i++)
//{
//    array[i] *= -1;
//    Console.Write(array[i] + " ");
//}

//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.  [1 2 3 4 5] -> 5 8 3    [6 7 3 6] -> 36 21

int [] array = new int[7];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,12);
    Console.Write(array[i] + " ");
}

Console.WriteLine();
// определяем чётность количества элементов в массиве - оригинале -> длину массива приёмника данных)
int[] array_new = null;
if(array.Length % 2 == 0)
{
    array_new = new int[array.Length / 2];
}
else
{
    array_new = new int[array.Length / 2 + 1];
}
// задаём переменные для счёта Произведений пар чисел (1*(n-1); 2*(n-2); ...)
int size = array.Length - 1;
int index = 0;
int count = 0;
int sum = 0;
while (count <= size)
{
    if (count == size)
    {
        array_new[index] = array[count];
        Console.Write(array_new[index] + " ");
    }
    else
    {
        sum = array[count] * array[size];
        array_new[index] = sum;
        Console.Write(array_new[index] + " ");
    }
index++;
count++;
size--;
}

