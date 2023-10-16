int n = int.Parse(Console.ReadLine()); //брой на числата, с който ще работя

int[] numbers = new int[n];

for (int index = 0; index <= numbers.Length - 1; index++)
{
    numbers[index] = int.Parse((Console.ReadLine()));
}

//{10, 20, 30} -> reverse -> {30, 20, 10}
//последния индекс към първия
for (int index = numbers.Length - 1; index >= 0; index--)
{
    Console.Write(numbers[index] + " ");
}
