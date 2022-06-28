/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

- /

/*Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

int n = (int)Math.Log10(number) - 2;

Console.WriteLine(n < 0 ? "No such digit" : (number % (int)Math.Pow(10, n + 1) / (int)Math.Pow(10, n)).ToString());

Console.ReadLine();*/

Console.WriteLine("Введите число");

string number = Console.ReadLine();

int numberN = int.Parse(number);

if (numberN > 99 && numberN < 1000)

{

    int thirdN = numberN % 10;

    Console.WriteLine("Полученное число {0}", thirdN);

}

else if (numberN < 99)

{

    Console.WriteLine("нет третьей цифры");

}

else if (numberN > 1000)

{

    string str = numberN.ToString();

    Console.WriteLine(str[2]);

}
