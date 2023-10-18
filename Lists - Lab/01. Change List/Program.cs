List<int> numbers = Console.ReadLine() //"1 2 3 4 5 5 5 6"
                    .Split(" ")        //["1", "2", "3", "4", "5", "5", "5", "6"]
                    .Select(int.Parse) //[1, 2, 3, 4, 5, 5, 5, 6]
                    .ToList();          //{1, 2, 3, 4, 5, 5, 5, 6}

//повтаряме: въвеждаме входни данни (команди или "end")
//стоп: входни данни == "end"
//продължаваме: входни данни != "end"

string command = Console.ReadLine();
while (command != "end")
{
    //валидна командa
    //1. command = "Delete 5".Split(" ") -> ["Delete", "5"]
    //2. command = "Insert 5 0".Split(" ") -> ["Insert", "5", "0"]
    string[] commandParts = command.Split(" "); 
    string commandName = commandParts[0]; //име на команда: "Delete" или "Insert"
    int element = int.Parse(commandParts[1]);
    
    if (commandName == "Delete")
    {
        //delete all elements in the array, which are equal to the given element
        //{1, 2, 3, 4, 5, 5, 5, 6}
        numbers.RemoveAll(number => number == element);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]);
        //insert the element at the given position
        numbers.Insert(position, element);

    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));