// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int NumAExponNumB(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result *= numA;
    }

    return result;
}

int Expon = NumAExponNumB(2, 4);
System.Console.WriteLine(Expon);