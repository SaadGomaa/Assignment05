using System;
class Program
{
    public static void SwapVal(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    public static void SwapRef(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    public static void SumAndSub(int first, int second, out int sum, out int sub)
    {
        sum = first + second;
        sub = first - second;
    }

    public static int SumDigits(int num)
    {
        int total = 0;
        while (num > 0)
        {
            total += num % 10;
            num /= 10;
        }
        return total;
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        for (int i = 3; i <= num / i; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    public static void MinMaxArray(int[] nums, ref int max, ref int min)
    {
        if (nums is null || nums.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty.");
        }
        int innerMin = int.MaxValue, innerMax = int.MinValue;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < innerMin) innerMin = nums[i];
            if (nums[i] > innerMax) innerMax = nums[i];
        }
        min = innerMin;
        max = innerMax;
    }

    public static long Factorial(int num)
    {
        if (num < 0)
        {
            throw new ArgumentOutOfRangeException("Number must be >= 0");
        }
        long result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

    public static string ChangeChar(string text, int index, char replace)
    {
        if (text is null)
        {
            throw new ArgumentNullException("text cannot be null");
        }
        ;
        if (index < 0 || index >= text.Length)
        {
            throw new ArgumentOutOfRangeException("Index is outside the string length");
        }
        char[] chars = text.ToCharArray();
        chars[index] = replace;
        return new string(chars);
    }


    static void Main(string[] args)
    {
        #region Q1
        // // Passing by value copies it 
        // int a = 5, b = 2;
        // System.Console.WriteLine("A => " + a);
        // System.Console.WriteLine("B => " + b);
        // SwapVal(a, b);
        // System.Console.WriteLine("After Swap ");
        // System.Console.WriteLine("A => " + a);
        // System.Console.WriteLine("B => " + b);
        #endregion

        #region Q2
        // // Passing by Ref modify the original variable
        // int a = 5, b = 2;
        // System.Console.WriteLine("A => " + a);
        // System.Console.WriteLine("B => " + b);
        // SwapRef(ref a,ref b);
        // System.Console.WriteLine("After Swap ");
        // System.Console.WriteLine("A => " + a);
        // System.Console.WriteLine("B => " + b);
        #endregion

        #region Q3
        // System.Console.Write("Enter Your Fisrt Number: ");
        // int.TryParse(Console.ReadLine(), out int num1);
        // System.Console.Write("Enter Your Second Number: ");
        // int.TryParse(Console.ReadLine(), out int num2);
        // SumAndSub(num1, num2, out int sum, out int sub);
        // System.Console.WriteLine($"Sum ==> {sum}");
        // System.Console.WriteLine($"Sub ==> {sub}");
        #endregion

        #region Q4
        // System.Console.Write("Enter Your Number: ");
        // int.TryParse(Console.ReadLine(), out int num);
        // int sum = SumDigits(num);
        // System.Console.WriteLine($"Sum of digits = {sum}");
        #endregion

        #region Q5
        // System.Console.Write("Enter Your Number: ");
        // int.TryParse(Console.ReadLine(), out int num);
        // bool state = IsPrime(num);
        // System.Console.WriteLine(state? "Prime Number" : "Not Prime");
        #endregion

        #region Q6
        // int[] nums =  [2,5,1,9,7];
        // int min = 0, max = 0;
        // MinMaxArray(nums, ref max, ref min);
        // System.Console.WriteLine($"Max ==> {max}");
        // System.Console.WriteLine($"Min ==> {min}");
        #endregion

        #region Q7
        // Console.Write("Enter Your Number: ");
        // int.TryParse(Console.ReadLine(), out int number);
        // System.Console.WriteLine($"Factorial {number} ==> {Factorial(number)}");
        #endregion

        #region Q8
        // Console.Write("Enter Your Word: ");
        // string text = Console.ReadLine();
        // Console.Write("Enter Your Char: ");
        // string ch = Console.ReadLine();
        // string result = ChangeChar(text, 0, ch[0]);
        // System.Console.WriteLine(result);
        #endregion
    }
    
}