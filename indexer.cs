using System;

public class A
{
	//indexer
	public int this[int index]
	{
		//MSIL - public int Get_Item(int index){}
		get
		{
			return 0;
		}

		//MSIL - public vois Set_Item(int value,int index){}
		set
		{
		//	Console.WriteLine($"{value} and {index}");
		}
	}

	public string this[string index]
	{
		get
		{
			return "";
		}

		set
		{
		//	Console.WriteLine($"{value} and {index}");
		}
	}
}

public class Program
{
	public static void Main()
	{
		A obj = new A();
		obj[0] = 10; //MSIL obj.GetItem(0);
		obj["first"] = "First";
	}
}
