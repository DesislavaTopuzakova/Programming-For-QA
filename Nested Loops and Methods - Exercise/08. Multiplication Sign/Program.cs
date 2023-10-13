int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

PrintSign(number1, number2, number3);



//метод, който отпечатва какъв е стойността
//на произведението на числата (number1 * number2 * number3)
static void PrintSign (int n1, int n2, int n3)
{
    //product = n1 * n2 * n3
    //product < 0; product > 0; product == 0

    //начин 1
    /*int product = n1 * n2 * n3; //произведение
    if (product < 0)
    {
        Console.WriteLine("negative");
    }
    else if (product > 0)
    {
        Console.WriteLine("positive");
    }
    else  //product == 0
    {
        Console.WriteLine("zero");
    }*/

    //начин 2
    if (n1 == 0 || n2 == 0 || n3 == 0)
    {
        Console.WriteLine("zero");
    }
    else if ((n1 > 0 && n2 > 0 && n3 > 0) 
           || (n1 < 0 && n2 < 0 && n3 > 0)
           || (n1 > 0 && n2 < 0 && n3 < 0)
           || (n1 < 0 && n2 > 0 && n3 < 0))
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("negative");
    }
}
