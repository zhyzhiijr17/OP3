

class Program
{
    static void Main()
    {
        Console.Write("Введіть число для обчислення факторіалу: ");
        int number = int.Parse(Console.ReadLine());

        long factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Факторіал числа {number} = {factorial}");
    }
}
