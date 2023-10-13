int n = int.Parse(Console.ReadLine());
//for цикъл -> знаем колко пъти искаме да повторим нещо
//начало
//край
//промяна


//всяка една стойност на първото число в паролата
for (int firstNumber = 2; firstNumber <= n; firstNumber += 2)
{
    //всяка една стойност на второто число от паролата
    for (int secondNumber = 1; secondNumber <= n; secondNumber += 2)
    {
        //парола: {firstNumber}{secondNumber}{firstNumber * secondNumber}
        Console.Write($"{firstNumber}{secondNumber}{firstNumber * secondNumber} ");
    }
}
