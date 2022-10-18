// Программа, которая на входе принимает два числа и выдаёт, какое число большее , а какое меньшее.

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

Console.Write("Введите второе число: ");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if (a > b)
{
    Console.WriteLine("Наибольшее число: " + a);
}

else
{
    Console.WriteLine("Наибольшее число: " + b);
}



