using System;
					
public class Program
{
	public static void Main()
	{	
	 double x, k,f;
	 Console.WriteLine("Ingrese un numero el Celius");
	 x=int.Parse(Console.ReadLine());
	 k = x + 273.15;
	Console.WriteLine("Kelvin="+ k);
	f = (x * 9/5) + 32; 
	Console.WriteLine("Fahrenheit="+f);	
	}
}