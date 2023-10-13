string password = Console.ReadLine();

//1. валидна дължина -> [6; 10]
//true -> валидна дължина
//false -> невалидна дължина
bool isValidLength = password.Length >= 6 && password.Length <= 10;

//2. валидно съдържание -> само букви и цифри
//true -> валидно съдържание
//false -> невалидно съдържание
bool isValidContent = CheckContent(password);

//3. валиден брой цифри -> брой цифри >= 2
//true -> валиден брой цифри
//false -> невалиден брой цифри
bool isValidCountDigits = CheckCountDigits(password);

//валидна парола
if (isValidLength == true && isValidContent == true && isValidCountDigits == true)
{
    //изпълнени 3 условия -> валидна парола
    Console.WriteLine("Password is valid");
}
else
{
    //невалидна парола

    //заради невалидна дължина
    if (isValidLength == false)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    //заради невалидно съдържание
    if (isValidContent == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }

    //заради брой на цифрите 
    if (isValidCountDigits == false)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
        
}



//метод, който проверява дали съдържанието на паролата е валидно
//true -> съдържанието е валидно
//false -> съдържанието не е валидно
static bool CheckContent (string password)
{
    //само букви или цифри
    for (int position = 0; position <= password.Length - 1; position++) 
    { 
        char symbol = password[position];
        //различен от буква или цифра
        //IsLetterOrDigit
        //true -> ако дадения символ е буква или цифра
        //false -> ако дадения символ не е буква или цифра

        if (char.IsLetterOrDigit(symbol) == false)
        {
            //дадения символ не е буква или цифра -> невалидно съдържание
            return false; //прекъсва метода и дава резултат от него false
        }
    }

    //преминали през всички символи -> валидни символи = валидно съдържание
    return true;
}

//метод, който проверява дали ми е валиден броя на цифрите
//true -> валиден брой на цифрите (брой >= 2)
//false -> невалиден брой на цифрите (брой < 2)
static bool CheckCountDigits (string password)
{
    int count = 0; //брой на цифрите
    for (int position = 0; position <= password.Length - 1; position++)
    {
        char symbol = password[position];
        //проверка дали символа е цифра -> ++
        //IsDigit
        //true -> подадения символ е цифра
        //false -> подадения символ не е цифра@
        if (char.IsDigit(symbol) == true)
        {
            count++;
        }
    }

    //брой на цифрите
    return count >= 2;
}