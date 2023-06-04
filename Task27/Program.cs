Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine()!;
int summa = 0;
for (int i = 0; i < number.Length; i++)
    summa = summa + Convert.ToInt32(number[i].ToString());
Console.WriteLine(summa);