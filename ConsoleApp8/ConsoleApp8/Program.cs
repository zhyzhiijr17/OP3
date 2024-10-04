

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = FindGCD(num1, num2);

        Console.WriteLine($"Найбільший спільний дільник (НСД) чисел {num1} і {num2} дорівнює {gcd}.");
    }

    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a); // Повертаємо абсолютне значення
    }
}
