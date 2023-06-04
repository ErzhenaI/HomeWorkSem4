Console.Clear();
Console.Write ("Введите первое число: ");
int A = int.Parse (Console.ReadLine()!);
Console.Write ("Введите второе натуральное число: ");
int B = int.Parse (Console.ReadLine()!);
while (B < 1)
{
    Console.Write ("Второе число не является натуральным!\n Введите второе натуральное число: ");
    B = int.Parse (Console.ReadLine()!);
}
int C = 1;
while (B > 0)
{
    C = C * A;
    B = B - 1;
}
Console.WriteLine ($"Результат: {C}");