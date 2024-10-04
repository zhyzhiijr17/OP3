

class Program
{
    static void Main()
    {
        Console.Write("Введіть число для перетворення в двійкову систему: ");
        int number = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(number, 2);

        Console.WriteLine($"Число {number} в двійковій системі: {binary}");
    }
}
