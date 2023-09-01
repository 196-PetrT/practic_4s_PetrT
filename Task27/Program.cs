// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumPositionNum(int numA)
{
    int SumP = default;
    string check = numA.ToString();
    for (int i = 0; i < check.Length; i++)
    {
        int result = numA % 10;
        SumP += result;
        numA = numA / 10;
    
    }

    return SumP;
}

int SumPosition = SumPositionNum(9012);
System.Console.WriteLine(SumPosition);