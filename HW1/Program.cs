/* Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/



Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
int numberN = int.Parse(number);

Console.WriteLine($"введенное число {numberN}");

int secondN = (numberN / 10) % 10;

Console.WriteLine("Полученное число {0}", secondN);
