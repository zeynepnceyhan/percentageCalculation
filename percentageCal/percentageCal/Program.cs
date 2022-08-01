class Program
{
    static void Main(string[] args)
    {
        int number, per, result;
        Console.WriteLine("Please give me a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter a percentage: ");
        per = Convert.ToInt32(Console.ReadLine());

        result = (number * per) / 100;

        Console.WriteLine("The x% of our number: " + result);

        Console.ReadLine();
    }

}

