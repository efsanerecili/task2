using System;

class Program
{
	static void Main()
	{

		int[] intArray = { -2, 2, -8, 1, -9, 3, -6 };


		int[] resultArray = ReverseAndAbs(intArray);


		Console.WriteLine("Musbetə çevrilmiş və tersinə qoyulmuş array: [" + string.Join(", ", resultArray) + "]");
	}


	static int[] ReverseAndAbs(int[] arr)
	{
		int length = arr.Length;
		int[] resultArray = new int[length];

		for (int i = 0; i < length; i++)
		{

			resultArray[length - 1 - i] = Math.Abs(arr[i]);
		}

		return resultArray;
	}
}


using System;
using System.Linq;

class Program
{
	static void Main()
	{

		int[] array = { 4, 2, 7, 1, 9, 3 };


		int minValue = array.Min();


		Console.WriteLine("Ən kiçik element: " + minValue);
	}
}


using System;

class Program
{
	static void Main()
	{
		string[] strArray = { "bir", "iki", "üç", "dörd" };


		Console.Write("Dizinin indeksini daxil edin: ");
		if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < strArray.Length)
		{

			strArray[index] = ReverseString(strArray[index]);


			Console.WriteLine("Tersinə çevrilmiş array: [" + string.Join(", ", strArray) + "]");
		}
		else
		{
			Console.WriteLine("Yanlış indeks daxil edildi.");
		}
	}


	static string ReverseString(string input)
	{
		char[] charArray = input.ToCharArray();
		Array.Reverse(charArray);
		return new string(charArray);
	}
}
