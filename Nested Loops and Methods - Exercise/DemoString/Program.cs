string name = "Softuni";

Console.WriteLine(name.Length); //дължина на текста = брой символи
//първи символ => 0 позиция
//последен символ -> дължина - 1

Console.WriteLine(name[0]); //първия символ
Console.WriteLine(name[name.Length - 1]); //последния символ

for (int position = 0; position <= name.Length - 1; position++)
{
    char symbol = name[position];
}