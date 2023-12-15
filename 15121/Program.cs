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