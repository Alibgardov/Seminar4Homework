Console.Clear();
Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Stepen = Method1(numA, numB);
Console.WriteLine(Stepen);

int Method1(int numberA, int numberB) // Создаём метод и даём ему 2 новые переменные NumberA и NumberB
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    // int result = Math.Pow(numberA, numberB);
    return result;
}


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16