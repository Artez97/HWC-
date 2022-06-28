/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите день недели");
string number = Console.ReadLine();
int numberN = int.Parse(number);

if (numberN == 1 || numberN == 2 || numberN == 3 || numberN == 4 || numberN == 5)
{
    Console.WriteLine($"будни");
}
else
{
    Console.WriteLine($"выходной");
}