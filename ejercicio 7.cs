using System;
					
public class Program
{
	public static void Main()
		
	{int a,b,r1,r2,r3,r4,r5;
	 Console.WriteLine("Ingrese el primer numero:");
	 a=int.Parse(Console.ReadLine());
	 
	 Console.WriteLine("Ingrese el segundo numero:");
	 b=int.Parse(Console.ReadLine());
	  
     r1=a+b;
	 r2=a-b;
	 r3=a/b;
	 r4=a*b;
	 r5=a%b;
	 
	 Console.WriteLine(a +"+"+ b+"="+r1);
	  Console.WriteLine(a +"-"+ b+"="+r2);
	  Console.WriteLine(a +"/"+ b+"="+r3);
	  Console.WriteLine(a +"*"+ b+"="+r4);
	 Console.WriteLine(a +"residuo"+ b+"="+r5);
	 
	 	
	}
	
}