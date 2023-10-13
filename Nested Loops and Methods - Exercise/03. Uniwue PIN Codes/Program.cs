//PIN: {firstDigit}{secondDigit}{thirdDigit}

int max1 = int.Parse(Console.ReadLine()); //макс стойност на firstDigit 
int max2 = int.Parse(Console.ReadLine()); //макс стойност на secondDigit
int max3 = int.Parse(Console.ReadLine()); //макс стойност на thirdDigit

//firstDigit: [2; max1] -> четна
//secondDigit: [1; max2] -> просто число от 2 до 7: 2, 3, 5, 7
//thirdDigit: [2, max3] -> четна

for (int firstDigit = 2; firstDigit <= max1; firstDigit += 2) //всички стойности на firstDigit
{
    for (int secondDigit = 1; secondDigit <= max2; secondDigit++) //всички стойности на secondDigit
    {
        for (int thirdDigit = 2; thirdDigit <= max3; thirdDigit += 2) //всички стойности на thirdDigit
        {
            //ПИН код: {firstDigit}{secondDigit}{thirdDigit}
            //secondDigit => 2, 3, 5, 7
           if (secondDigit == 2 || secondDigit == 3 || secondDigit == 5 || secondDigit == 7)
           {
                //втората цифра е някое просто число в диапазона от 2 до 7 -> валиден ПИН код
                Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}");

            }
        }
    }
}