Console.Clear();
Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int sumNumber = Math.Abs(Method1(numberA));
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

int Method1(int chislo)
{
    int count = Convert.ToString(chislo).Length;
    int advance = 0;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        advance = chislo - chislo % 10;
        sum = sum + (chislo - advance);
        chislo = chislo / 10;
    }
    return sum;
}








// //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12