int countNumbers = int.Parse(Console.ReadLine()); //брой на числата
int maxNumber = int.MinValue; //най-голямото число

for (int number = 1; number <= countNumbers; number++)
{
    //променлива, в която съхраняваме стойността на числото
    int value = int.Parse(Console.ReadLine()); //стойността на числото

    //проверка дали е най-малкото
    if (value > maxNumber)
    {
        maxNumber = value;
    }

}

//преминали през всички числа -> знаем кое е най-малкото
Console.WriteLine(maxNumber);
