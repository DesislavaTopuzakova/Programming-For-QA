int n = int.Parse(Console.ReadLine());

//трицифрени числа
//{digit1}{digit2}{digit3}

//всички трицифрени числа
//100 до 999
//първа цифра: [1; 9]
//втора цифра: [0; 9]
//трета цифра: [0; 9]

for (int digit1 = 1; digit1 <= 9; digit1++) //всички стойности за първата цифра
{
    for (int digit2 = 0;digit2 <= 9; digit2++) //всички стойности за втората цифра
    {
        for (int digit3 = 0; digit3 <= 9; digit3++) //всички стойности за третата цифра
        {
            //трицифрено число: {digit1}{digit2}{digit3}
            //проверка дали е магическо
            if (digit1 * digit2 * digit3 == n)
            {
                //магическо число
                Console.Write($"{digit1}{digit2}{digit3} ");
            }
        }
    }
}
