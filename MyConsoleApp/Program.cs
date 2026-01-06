
Dictionary<string, int> people = new Dictionary<string, int>();

    people.Add("Alice", 30);    
    people.Add("Bob", 25);  
    people.Add("Charlie", 35); 

    foreach (var person in people)
    {
        Console.WriteLine($"{person.Key} is {person.Value} years old.");
    }
    

int[]numbers = { 1, 2, 3, 4, 5 };

    int sum = numbers.Sum();
    Console.WriteLine($"The sum of the numbers is: {sum}"); 


int[] numberss = { 100, 200, 300, 400, 500, 600, 700 };
int largest = numberss[0];
int smallest = numberss[1];

foreach (int number in numbers)
{
    if (number > largest)
        largest = number;

    if (number < smallest)
        smallest = number;  
}

Console.WriteLine($"The largest number in the array is {largest}");
Console.WriteLine($"The smallest number in the array is {smallest}");