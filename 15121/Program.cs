// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве. Программа 
// должна выдать ответ: Да/Нет.
//
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введите число");
//         int num = Convert.ToInt32(Console.ReadLine());

//         int[] array = new int[5];

//         bool isFind = false;

//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = new Random().Next(1, 10);
//             Console.Write(array[i] + " ");

//             if (array[i] == num)
//             {
//                 isFind = true;
//             }
//         }
//         if (isFind == true)
//         {
//             Console.Write("Да");
//         }
//         else
//         {
//             Console.Write("Нет");
//         }
//     }
// }
// Задание 2. Обсуждение решений
// Семинар 3. Массивы
// 10 мин
// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int[] array = new int[10];

//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = new Random().Next(-10, 11);
//             Console.Write(array[i] + " ");
//         }
//         Console.WriteLine();
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = array[i] * -1;
//             Console.Write(array[i] + " ");
//         }
//     }
// }

// Задание 3. Совместная работа
// Семинар 3. Массивы
// 15 мин
// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];
// int[] array2 = new int[num/2];
// for(int i = 0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(0,12);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// for(int i = 0; i<array2.Length; i++)
// {
//     if(i == array.Length - i - 1)
// {  
// return;
// }
//     array2[i] = array[i] * array[array.Length - i - 1];
//     Console.Write(array2[i] + " ");
// }

// Задание 4*. Совместная работа
// [если позволит тайминг]
// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[3];
// if(num<1000 && num>99)
// {
//     array[0] = num%10;
//     array[1] = num/10%10;
//     array[2] = num/100;
//     for(int i = 0; i<array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// }
// else
// {
// Console.WriteLine("Число не подходит");
// }

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string newnum = "";
while(num>0)
{
    newnum = newnum + (num%10).ToString();
    num = num/10;
}
int i = newnum[newnum.Length-1];
Console.Write("{");
Console.Write(newnum[newnum.Length-1] + ", ");
for(i = 1; i<newnum.Length-1; i++)
{
    Console.Write(newnum[newnum.Length-i-1] + ", ");
}
    Console.Write(newnum[newnum.Length-i-1]);
    Console.Write("}");    
    





