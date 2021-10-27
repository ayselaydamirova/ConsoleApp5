//// C# program to illustrate the 
//// String.IndexOf(char x) method
//using System;
//namespace ConsoleApplication1
//{

//    class program
//    {

//        // Main Method
//        static void Main(string[] args)
//        {

//            string str = "AYSELAYDAMIROVA";

//            int index1 = str.IndexOf('Y');

//            Console.WriteLine("The Index Value of character 'Y' is " + index1);



//            int index2 = str.IndexOf('C');

//            // Char bu stringde deyilse value -1 qaytarmalidir
//            Console.WriteLine("The Index Value of character 'C' is " + index2);
//        }
//    }
//}
//// A C# program to
//// find floor(sqrt(x))

//class program
//{
//	// Returns floor of
//	// square root of x
//	static int floorSqrt(int x)

//	{
//		// Base cases
//		if (x == 0 || x == 1)
//			return x;

//		// 1-den basliyaraq hamsini yoxluyur
//		// i*i olana qeder 
//		// x-den boyuk ve ya beraberdir shertide daxil olmaqla
//		int i = 1, result = 1;


//		while (result <= x)
//		{
//			i++;
//			result = i * i;
//		}
//		return i - 1;

//	}

//	// Driver Code
//	static public void Main()
//	{
//		int x = 11;
//        System.Console.WriteLine(floorSqrt(x));
//	}
//}




//// ədədin rəqəmlərinin cəmini tapmaq
//using System;

//class program
//{

//	static int sum_of_digit(int n)
//	{
//		if (n == 0)
//			return 0;

//		return (n % 10 + sum_of_digit(n / 10));
//	}

//	//ədədləri yoxlamaqla
//	public static void Main()
//	{
//		int num = 76589;
//		int result = sum_of_digit(num);
//		Console.WriteLine("Sum of digits in " +
//						num + " is " + result);
//	}
//}

//// maksimum elementi tapan program arr[]
//using System;

//class program
//{

//	static int[] arr = { 8, 43, 50, 90, 2021 };

//	//  arr[] maksimumu tapan metod
//	static int largest()
//	{
//		int i;

//		//  maximum elementi ishe salaq
//		int max = arr[0];

//		// masivv elementlrini ikiciden basliyaraq yoxluyuruq
//		// ve cari maksimum elementi ile müqayise edirik
//		for (i = 1; i < arr.Length; i++)
//			if (arr[i] > max)
//				max = arr[i];

//		return max;
//	}

//	// Driver method
//	public static void Main()
//	{
//		Console.WriteLine("Largest in given "
//				+ "array is " + largest());
//	}
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        // 2 qiymeti hesabliyiriq
//        int value1 = -1000;
//        int value2 = 20;
//        int abs1 = Math.Abs(value1);
//        int abs2 = Math.Abs(value2);

//        // alinan neticeni ekrana yazdiririq
//        Console.WriteLine(value1);
//        Console.WriteLine(abs1);
//        Console.WriteLine(value2);
//        Console.WriteLine(abs2);

//        // End.
//        Console.WriteLine();
//    }
//}

