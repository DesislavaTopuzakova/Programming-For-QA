int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

//1 начин
//Console.WriteLine(Math.Pow(number, power));

//2 начин -> цикли
//повтаряме
int result = 1; //резултатът от степенуването
for (int time = 1; time <= power; time++)
{
    result = result * number;
}
//след като преминем през всички операции
Console.WriteLine(result);