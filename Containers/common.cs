public class Jint : CustTypeName , Number , Valued
{
	int self;
	public string name()
	{
		return "int";
	}
	public double get_value()
	{
		return self;
	}
	public void change(int vale)
	{
		self = vale;
	}
	public static void set(string[] equation, Data D, base_runner Base, int i, int k)
	{
		int math = DoMath(equation.Skip(2));
		Jint = D.refrenceCustom("int"equation0
		switch(equation[1])
		{
			case "=":
				D.refrenceCustom("int",equation[0]).change(math);
				break;
			case "+=":
				D.refrenceCustom("int",equation[0]).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()+math);
				break;
		}
	}
	
}




public class Jdouble : CustTypeName , Number , Valued
{
	double self;
	public string name()
	{
		return "double";
	}
	public double get_value()
	{
		return self;
	}
	public object getV()
	{
		return self;
	}
	
	
}


public class Jstring : CustTypeName , Valued
{
	string self;
	public string name()
	{
		return "string";
	}
	public object getV()
	{
		return self;
	}
	
	
}



public class method : CustTypeName
{
	
	
	
}