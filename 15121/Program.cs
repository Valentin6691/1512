// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве. Программа 
// должна выдать ответ: Да/Нет.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int num = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[5];

        bool isFind = false;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 10);
            Console.Write(array[i] + " ");

            if (array[i] == num)
            {
                isFind = true;
            }
        }
        if (isFind == true)
        {
            Console.Write("Да");
        }
        else
        {
            Console.Write("Нет");
        }
    }
}