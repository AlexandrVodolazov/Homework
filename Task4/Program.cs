// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);


for (int x = 1; x <= a; x++)
    if (x % 2 == 0)

        Console.WriteLine(x);



        



