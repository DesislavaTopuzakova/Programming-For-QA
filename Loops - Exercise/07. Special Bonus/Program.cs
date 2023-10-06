int stopNumber = int.Parse(Console.ReadLine()); //число, което ако въведем спираме

//повтаряме: въвеждаме числа -> проверка дали съвпада с stopNumber
int prevNumber = 0; //последно въведено число

while (true)
{
    int number = int.Parse(Console.ReadLine()); //въведено число
    if (number == stopNumber)
    {
        //1. увеличавам предното с 20%
        //2. принтирам
        //prevNumber + 20% = prevNumber + 0.20 * prevNumber = 1.2 * prevNumber
        Console.WriteLine(prevNumber * 1.2);
        break;
    }

    prevNumber = number;
}