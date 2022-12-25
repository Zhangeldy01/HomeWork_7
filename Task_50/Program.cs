/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Write("Введите индекс строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбеца: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Random rnd = new Random();
Console.WriteLine("Массив: ");
int[,] arr = new int[rnd.Next(1, 10), rnd.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = rnd.Next(0, 10);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if ((x < 0) || (x >= arr.GetLength(0)) || (y < 0) || (x >= arr.GetLength(1)))
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0} ", arr[x, y]);
}
Console.ReadLine();