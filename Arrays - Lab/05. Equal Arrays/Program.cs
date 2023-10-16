int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


for (int index = 0;  index <= firstArray.Length - 1; index++)
{
    if (firstArray[index] != secondArray[index])
    {
        //имаме различни елементи на еднакви позиции -> масивите не са еднакви
        Console.WriteLine("Arrays are not identical.");
        return; //прекратява цялата програма
    }
}

//обходили всички числа и не сме прекратили програмата -> масивите са еднакви
Console.WriteLine("Arrays are identical.");

