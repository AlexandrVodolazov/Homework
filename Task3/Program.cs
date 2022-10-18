// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);




if (a % 2 == 0)
{
    Console.WriteLine(a + " - является четным");
}

else
{
    Console.WriteLine(a + " - не является четным");
}



