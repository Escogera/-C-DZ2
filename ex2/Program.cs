/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/


Console.WriteLine("Введите число");
int[] numbers = new int [2];
int size = numbers.Length;
if(numbers.Length<3)
{
    Console.WriteLine("третий цифры нет");
}
else
{
    Console.WriteLine(numbers[2]);
}