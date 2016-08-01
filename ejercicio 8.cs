using System;
					
public class Program
{
	public static void Main()
		
	{int numero,resultado;
	 Console.WriteLine("Ingrese el valor a multiplicar:");
	 numero=int.Parse(Console.ReadLine());
	
	 for (int i = 0; i <= 10; i++ )
                        {
                            resultado = numero * i;
                           Console.WriteLine(numero+ " * " +i+ " = " +resultado);
                        }
	

	}
}