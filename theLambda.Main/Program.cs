using TheLambda;

string Question1 = @"
This makes the program shorter because the bool expression is just in the Sieve constructor parameters instead of making an entire new method.
";
string Question2 = @"
It makes it a little more confusing to read if because lambda expresions don't fully have the logic written out like a method.
Like the book says though people will use lambda and knowing of it is very helpful.
";

Console.WriteLine("Welcome to the Sieve enter a number and you will know if it is good or bad");
Console.WriteLine("Would you like to see (even numbers), (positive numbers) or (multiples of ten)?");
string? getProgram = Console.ReadLine();

Sieve sieve = getProgram switch
{
    "even numbers" => new Sieve(number => number % 2 == 0),
    "positive numbers" => new Sieve(number => number > 0),
    "multiples of ten" => new (number => number / 10 >= 1)
};

while (true)
{
    
    try
    {
        Console.WriteLine("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        string goodOrEvil = sieve.IsGood(number) ? "good" : "evil";
        Console.WriteLine($"That number is {goodOrEvil}");
    }catch(FormatException e)
    {
        Console.WriteLine(e.Message);
    }
}
// for the question at the end of the challenge if you want to read it you can just read the string or comment out the while loop then run the program.
Console.WriteLine(Question1);
Console.WriteLine(Question2);

bool IsEven(int numbers)
{
    if(numbers % 2 == 0)
    {
        return true;
    }else
    {
        return false;
    }
}

bool IsPositive(int numbers)
{
    if( numbers > 0)
    {
        return true;
    }else
    {
        return false;
    }
}

bool IsMultipleOfTen(int numbers)
{
    if( numbers / 10 >= 1)
    {
        return true;
    }else
    {
        return false;
    }
}