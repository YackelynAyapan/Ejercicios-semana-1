using System;
					
public class Program
{
	public static void Main()
	{
		int n1, n2, r;
            Console.WriteLine("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            r = n1+ n2;
            Console.WriteLine("El resultados es: " + r);
            Console.ReadLine();
		
	}
}