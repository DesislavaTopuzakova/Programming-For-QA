int number = int.Parse(Console.ReadLine()); //число, което ще проверявам и модифицирам
int startNumber = number; //първоначално въведенто число, което няма да се променя

bool isSpecial = true;
//isSpecial = true -> числото е специално
//isSpecial = false -> числто не е специално

//стоп: нямаме повече цифри -> number <= 0
//продължаваме: имаме налични цифри -> number > 0
while (number > 0)
{
    //1. последна цифра
    int lastDigit = number % 10;
    //2. проверка дали дели числото
    if (startNumber % lastDigit != 0)
    {
        //имаме цифра, която не дели числото -> не е специално
        isSpecial = false;
        break;
    }
    //3. премахвам последната цифра
    number = number / 10; //number /= 10;
}

//1. преминали сме през всички цифри -> всички цифри делят числото -> isSpecial = true
//2. имаме цифра, която не дели числото -> isSpecial = false


//проверка дали е спцеиално
if (isSpecial == true)
{
    //специално
    Console.WriteLine(startNumber + " is special");
}
else  //isSpecial == false
{
    //не е специално
    Console.WriteLine(startNumber + " is not special");
}

