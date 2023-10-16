int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

//1. факториел на първото число
int factFirstNumber = CalculateFactorial(firstNumber);


//2. факториел на второто число
int factSecondNumber = CalculateFactorial(secondNumber);


//3. факториел на първото число / факториел на второто число
Console.WriteLine(factFirstNumber / factSecondNumber);


//метод, който изчислява и връща стойността на факториела
static int CalculateFactorial(int number)
{
	//5! = 1 * 2 * 3 * 4 * 5
	int fact = 1; //факториел на числото
	for (int i = 1; i <= number; i++)
	{
		fact = fact * i;
	}
    //изчислен факториел в fact
    return fact;
}
