int n = int.Parse(Console.ReadLine());

string[] days = {"Monday", 
                "Tuesday", 
                "Wednesday", 
                "Thursday", 
                "Friday",
                "Saturday",
                "Sunday"};
//[1; 7]
if (n >= 1 && n <= 7)
{
    Console.WriteLine(days[n - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}
