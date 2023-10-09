//повтаряме: въвеждаме данни
//стоп: input == "End"
//продължаваме: input != "End"
double balance = 0; //баланс на сметката

string input = Console.ReadLine(); //входни данни: "500" или "End"

while (input != "End")
{
    //входни данни са число под формата на текст "500"
    //"500" -> double 500
    double money = double.Parse(input); //пари, които внасяме / теглим
    if (money >= 0)
    {
        //внасяне
        balance += money;
        Console.WriteLine($"Increase: {money:F2}");
    }
    else //money < 0
    {
        //теглим
        balance -= Math.Abs(money);
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
    }


    input = Console.ReadLine();
}

//входни данни == "End"
Console.WriteLine($"Balance: {balance:F2}");