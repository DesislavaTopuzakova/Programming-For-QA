int countNumbers = int.Parse(Console.ReadLine());

int count2 = 0; //брой на числа, които се делят на 2
int count3 = 0; //брой на числа, които се делят на 3
int count4 = 0; //брой на числа, които се делят на 4


for (int number = 1; number <= countNumbers; number++)
{
    int value = int.Parse(Console.ReadLine()); //стойност на числото
    //проверка дали се дели на 2, 3, 4
    if (value % 2 == 0)
    {
        //числото се дели на 2
        count2++;
    }

    if (value % 3 == 0) 
    {
        //числото се дели на 3
        count3++;
    }

    if (value % 4 == 0) 
    { 
        //числото се дели на 4
        count4++;
    }
}

//всички числа
//брой на числа, които се делят на 2 -> count2
//брой на числа, които се делят на 3 -> count3
//брой на числа, които се делят на 4 -> count4

double percent2 = count2 * 1.0 / countNumbers * 100;
double percent3 = count3 * 1.0 / countNumbers * 100;
double percent4 = count4  * 1.0/ countNumbers * 100;

Console.WriteLine($"{percent2:F2}%");
Console.WriteLine($"{percent3:F2}%");
Console.WriteLine($"{percent4:F2}%");
