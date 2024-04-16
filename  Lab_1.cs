using System;

public class MyLab
{
    public static void Main()
    {
        int n = 0;
        int i = 0;
        int s = 0;

        Console.WriteLine("Please enter value for N:");
        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i += 1)
        {
            if (i % 2 == 0)
            {
                s = s + i;
                Console.WriteLine("Current value i=" + i + " S=" + s);
            }
        }

        Console.WriteLine("Final result suma is S=" + s);
    }
}
