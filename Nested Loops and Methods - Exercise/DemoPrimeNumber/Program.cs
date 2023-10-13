int number = int.Parse(Console.ReadLine());
bool isPrime = CheckPrimeNumber(number);

if (isPrime)
{
    Console.WriteLine("Number is prime.");
}
else //isPrime == false
{
    Console.WriteLine("Number is NOT prime.");
}


//метод, който да проверява дали числото е просто
//true -> ако числото е просто
//false -> ако числото не е просто

static bool CheckPrimeNumber (int number)
{
    int count = 0; //брой на делителите
	for (int i = 1; i <= number; i++)
	{
		//проверка дали е делител
		if (number % i == 0)
		{
			count++;
		}
	}

	//знаем броят на делителите
	return count == 2;
}
