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
		int math = (int)DoMath(equation.Skip(2),D,Base);
		Jint = D.refrenceCustom("int"equation0
		switch(equation[1])
		{
			case "=":
				D.refrenceCustom("int",equation[0]).change(math);
				break;
			case "+=":
				D.refrenceCustom("int",equation[0]).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()+math);
				break;
			case "-=":
				D.refrenceCustom("int",equation[0]).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()-math);
				break;
			case "*=":
				D.refrenceCustom("int",equation[0]).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()*math);
				break;
			case "/=":
				D.refrenceCustom("int",equation[0]).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()/math);
				break;
			case "++":
				D.refrenceCustom("int",equation[0]).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()+1);
				break;
			case "--":
				D.refrenceCustom("int",equation[0]).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()-1);
				break;
			case "**":
				D.refrenceCustom("int",equation[0]).change((int)(((Jint)D.refrenceCustom("int",equation[0])).get_value()*((Jint)D.refrenceCustom("int",equation[0])).get_value()));
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


public class Jstring : CustTypeName , Valued , Hashable
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
	public static string Dehash(byte[] d)
	{
		 return Encoding.UTF8.GetString(d);
	}
	public byte[] hash()
	{
		return Encoding.UTF8.GetBytes(self);
	}
	
	
}