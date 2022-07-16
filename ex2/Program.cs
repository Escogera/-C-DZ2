/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
void ThirdNumber(string x)
{
    if(x.Length<3)
    {
        Console.Write(x+" -> третий цифры нет");
    }
    else
    {   
        Console.Write(x+" -> "+x[2]);
    }
}
ThirdNumber(number);