// 12, 22, 34, 56, 67

int[] numbers = {12, 22, 34, 56, 67};

//дължина на масив = брой елементи = 5
Console.WriteLine(numbers.Length);

//първия елемент в масива
Console.WriteLine(numbers[0]);

//последния елемент в масива
Console.WriteLine(numbers[numbers.Length - 1]);


//10 цели числа
int[] prices = new int[4];

prices[0] = 5;
prices[1] = 34;
prices[2] = 56;
prices[3] = 98;

//{5, 34, 56, 98}
//повтаряме: взимам елемента -> отпечатвам
for (int index = 0; index <= prices.Length - 1; index++)
{
    Console.WriteLine(prices[index]);
}


//Console.WriteLine(prices[10]); //DO NOT -> Exception


//7 числа въведени от конзолата
/*int[] nums = new int[7];

for (int index = 0; index <= nums.Length - 1; index++)
{
    nums[index] = int.Parse(Console.ReadLine());
}*/


string text = "dog, cat, frog, rabbit, turtle";
string[] animals = text.Split(", ");
//["dog", "cat", "frog", "rabbit", "turtle"]

Console.WriteLine(string.Join("\n", animals));




double[] grades = { 3.40, 4.50, 5.60, 6.00 };
//Length = 4

//ако ще работим с индексите на масива -> for
for (int index = 0;index <= grades.Length - 1; index++)
{

}

//ако ще работим с елементите на масива (без да ни трябват индексите) -> foreach
//[3.40, 4.50, 5.60, 6.00]
foreach (double grade in grades)
{
    //повтаряме за всяка една дробна стойност
    Console.WriteLine(grade);
}

