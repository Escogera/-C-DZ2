/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число соответствующее дню недели");
int number = Convert.ToInt32(Console.ReadLine());
if(0<number&&number<6)
{
    Console.WriteLine(number+" -> нет");
}
else if (5<number&&number<8)
{
    Console.WriteLine(number+" -> да");
}
else
{
    Console.WriteLine("введите число от 1 до 7");
}