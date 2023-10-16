int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

//[1, 2, 3, 4, 5, 6]
//1. сума на четни числа в масива
int sumEven = 0;

//2. сума на нечетни числа в масива
int sumOdd = 0;

//[1, 2, 3, 4, 5, 6]
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        //четно
        sumEven += number;
    }
    else
    {
        //нечетно число
        sumOdd += number;
    }
}

//3. сума на четни числа в масива -  сума на нечетни числа в масива
Console.WriteLine(sumEven - sumOdd);
