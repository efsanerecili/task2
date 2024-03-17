using System;

class Program
{
	static void Main()
	{

		Console.WriteLine(Max(1, 7, 5, 8, 4));


	}
	public static int Max(params int[] arr)
	{
		int max = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] > max)

			{
				max = arr[i];
			}


		}
		return max;
	}
}



using System;

class Program
{
	 public static void Main()
	{

		Polindrom(1551);


	}

	public static void Polindrom(int n)
	{

		int newN = n;
		int qaliq = 0;
		int m = 0;
		while (n > 0)
		{
			qaliq = n % 10;
			m = m * 10 + qaliq;
			n /= 10;
		}
		if (newN == m)
		{
			Console.WriteLine("eded polindromdur");
		}
		else
		{
			Console.WriteLine("eded polindrom deyil");
		}

	}




	using System;

class Program
{
	public static void Main()
	{

		ortaqelementleritap(["sevinc", "nergiz", "lale"], ["efsane", "fidan"]);

	}

	public static void ortaqelementleritap(string[] array1, string[] array2)
	{
		for (int i = 0; i < array1.Length; i++)
		{
			for (int j = 0; j < array2.Length; j++)
			{
				if (array1[i] == array2[j])
				{
					Console.WriteLine(array1[i]);

				}


			}
		}
	}
}





using System;

class Program
{
	public static void Main()
	{

		elemntlerinhasilinitap([2, 4, 1, 6]);

	}

	public static void elemntlerinhasilinitap(int[] array)
	{
		int hasil = 1;

		for (int i = 0; i < array.Length; i++)
		{

			hasil *= array[i];

		}

		{ Console.WriteLine("elementlerin hasili:" + hasil); }



	}
}



using System;

class Program
{
	public static void Main()
	{
		elementitap(["Ali", "efsane", "aydan", "Aysu"], 'A');
	}



	public static void elementitap(string[] array, char herf)
	{
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i][0] == herf)
			{ Console.WriteLine(array[i]); }

		}

	}

}




using System;

class Program
{
	public static void Main()
	{
		FibonacciSirasi(7);
	}


	public static void FibonacciSirasi(int n)
	{

		int a = 0;
		int b = 1;



		for (int i = 0; i < n; i++)
		{
			Console.WriteLine(a);
			int temp = a;
			a = b;
			b = temp + b;
		}

		return;
	}
}

