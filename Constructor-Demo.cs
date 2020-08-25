using System;
			
public class A{
	static int x;
	int y;
	
	public A(){Console.WriteLine("Default Constructor"); }
	
	public A(int arg):this() {
		Console.WriteLine("Overloaded Constructor");
	}
	static A(){ 
		
		Console.WriteLine("Static Constructor");
	}
	public static void Init(){  Console.WriteLine("Init"); }
}
public class Program
{
	//Main Thread
	public static void Main()
	{
		//A obj=new A();//Type Load - First allocate Memory For static data members and invoke static constructor
		//A newObj=new A();
		A.Init();//Type Load
		A obj=new A();//Default Constructor
		A newObj=new A(10);//Overloaded Constructor
		
	}
}
