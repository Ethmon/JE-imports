public class Pair : CustTypeName
{
	public string name()
	{
		return "Pair";
	}
	public object a;
	public object b;
	string type;
	public static void set(string[] equation, Data D, base_runner Base, int i, int k)
	{
		Pair p = D.refrenceCustom("Pair",code[0]);
		bool aorb = (code[1]=="$0") : false ? (code[1]=="$1") : true ? throw new Exception("out of bounds");
		
	}
	public static string[] get1(string[] equation, Data D, base_runner Base, int i, int k)
		return {D.refrenceCustom("Pair",equation[i+1]).a,2);
	public static string[] get2(string[] equation, Data D, base_runner Base, int i, int k)
		return {D.refrenceCustom("Pair",equation[i+1]).b,2);
	public Pair(string type)
	{
		this.type = type;
	}
	public Pair(string type, var a, var b)
	{
		this.type = type;
		this.a = a;
		this.b = b;
	}
	public static void Pair_set(List<string> code, Data D, base_runner Base)
	{
		
	}
	public static bool operator ==(Pair a,Pair b)
	{
		if(a.a == b.a)
			if (a.b == b.b)
				return true;
		return false;
	}
	public static bool operator !=(Pair a, Pair b)
	{
		if(a.a == b.a)
			if (a.b == b.b)
				return false;
		return true;
		
	}
	public static bool operator <(Pair a, Pair b)
	{
		if(a.a == b.a)
			return (a.b < b.b);
		return (a.a < b.a);
	}
	public static bool operator >(Pair a, Pair b)
	{
		if(a.a == b.a)
			return (a.b > b.b);
		return (a.a > b.a);
	}
	public static bool operator <=(Pair a, Pair b)
	{
		if(a.a == b.a)
			return (a.b <= b.b);
		return (a.a <= b.a);
	}
	public static bool operator >=(Pair a, Pair b)
	{
		if(a.a == b.a)
			return (a.b >= b.b);
		return (a.a >= b.a);
	}
	public bool Equals(Pair p)
	{
		if(this.a == p.a)
			if (this.b == p.b)
				return true;
		return false;
	}
	
}
public class Pair_instantiate : command_centrall
{
	public override void Execute(List<string> code, Data D, base_runner Base)
	{
		string name = code[1];
		string type = code[2];
		if(code.Count()==3)
		{
			Pair_data.Pairs[name] = new Pair(type);
			D.set
		}
		// else
		// {
			// if(keys.contains(name))
			// Pair_data.Pairs[name] = new Pair(type);
			// if(code[3] == "=")
			// {
				// if(code[4] == "$0")
				// {
					
					
				// }else if(code[4] == "$1")
				// {
					
				// }
			// }
		
		// }
		

	}
}