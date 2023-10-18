List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine(); //входни данни

while (command != "end")
{
    
    if (command.StartsWith("Add"))
    {
        //command = "Add 3".Split(" ") -> ["Add", "3"]
        //add a number to the end of the list
        int numberToAdd = int.Parse(command.Split(" ")[1]);
        numbers.Add(numberToAdd);
    }
    else if (command.StartsWith("RemoveAt"))
    {
        //command = "RemoveAt 0".Split(" ") -> ["RemoveAt", "0"]
        //remove a number at a given index
        int indexToRemove = int.Parse(command.Split(" ")[1]);
        numbers.RemoveAt(indexToRemove);
    }

    else if (command.StartsWith("Remove"))
    {
        //command = "Remove 4".Split(" ") -> ["Remove", "4"]
        //remove a number from the list
        int numberToRemove = int.Parse(command.Split(" ")[1]);
        numbers.Remove(numberToRemove);
    }
    else if (command.StartsWith("Insert"))
    {
        //command = "Insert 10 0".Split(" ") -> ["Insert", "10", "0"]
        //insert a number at a given index
        int numberToInsert = int.Parse(command.Split(" ")[1]);
        int indexToInsert = int.Parse(command.Split(" ")[2]);
        numbers.Insert(indexToInsert, numberToInsert);
    }
    
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
