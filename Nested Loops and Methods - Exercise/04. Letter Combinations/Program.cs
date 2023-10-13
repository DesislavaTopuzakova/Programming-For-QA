char startLetter = char.Parse(Console.ReadLine()); //начална буква
char endLetter = char.Parse(Console.ReadLine()); //крайна буква
char excludedLetter = char.Parse(Console.ReadLine()); //буква за изключване

//letter1: [startLetter; endLetter]
//letter2: [startLetter; endLetter]
//letter3: [startLetter; endLetter]

int count = 0; //брой на валидните комбинации

//всички комбинации
for (char letter1 = startLetter; letter1 <= endLetter; letter1++)
{
	for (char letter2 = startLetter; letter2 <= endLetter; letter2++)
	{
		for (char letter3 = startLetter; letter3 <= endLetter; letter3++)
		{
            //комбинация: {letter1}{letter2}{letter3}
            //изключим комбинации, които съдържат excludedLetter
            if (letter1 != excludedLetter && letter2 != excludedLetter && letter3 != excludedLetter)
            {
                //валидна -> комбинация, в която няма буква за изключване (excludedLetter)
                Console.Write($"{letter1}{letter2}{letter3} ");
                count++;
            }
        }
    }
}

//принтирали всички валидни комбинации
Console.WriteLine(); //курсора на нов ред, за да може следващата стойност да се отпечата на нов ред
Console.WriteLine(count);