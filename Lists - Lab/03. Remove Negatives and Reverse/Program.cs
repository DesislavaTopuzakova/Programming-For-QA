List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
//{10, -5, 7, 9, -33, 50}

numbers.RemoveAll(number => number < 0);
//{10, 7, 9, 50}

numbers.Reverse();
//{50, 9, 7, 10}

//нямаме елементи
if(numbers.Count == 0)
{
    //празен списък
    Console.WriteLine("empty");
}
else
{
    //списък пълен с числа
    Console.WriteLine(string.Join(" ", numbers));
}
