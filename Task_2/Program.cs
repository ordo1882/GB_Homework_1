// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter three numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 > num2 && num1 > num3)
{
    max = num1;
}
else if (num2 > num1 && num2 > num3)
{
    max = num2;
}
else
{
    max = num3;
}

Console.Write("The greater number is ");
Console.WriteLine(max);