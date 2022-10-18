// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

Console.Write("Введите второе число: ");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

Console.Write("Введите второе число: ");
string number3 = Console.ReadLine();
int c = Convert.ToInt32(number3);


if (a > b)
{
    Console.WriteLine("Наибольшее число: " + a);
}

else
{
    Console.WriteLine("Наибольшее число: " + b);
}

if (c > b)
{
    Console.WriteLine("Наибольшее число: " + c);
}
