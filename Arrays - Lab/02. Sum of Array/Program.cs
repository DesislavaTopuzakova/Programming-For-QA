int[] numbers = Console.ReadLine() //"5 3 6 3 4"
                .Split(" ")  //["5", "3", "6", "3", "4"]
                .Select(int.Parse) //[5, 3, 6, 3, 4]
                .ToArray();

int sum = 0; //сума на елементите в масива
for (int index = 0; index <= numbers.Length - 1; index++)
{
    sum += numbers[index];
}

//преминали сме през всички елементи
Console.WriteLine(sum);
