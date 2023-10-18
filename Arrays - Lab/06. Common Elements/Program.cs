int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


foreach (int number in firstArray)
{
    foreach (int number2 in secondArray)
    {
        if (number == number2)
        {
            //общ елемент, който го има в двата масива
            Console.Write(number + " ");
            break;
        }
    }
}

