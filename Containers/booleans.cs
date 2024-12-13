namespace booleans
{
	public enum normal
	{
		True,
		False,
		Default
	}
	public enum special
	{
		Default,
		True,
		False,
		Neither,
		Both,
		Unknown,
		Partially_True,
		Partially_False
		
	}
	public class Jbool : jumpE_basic.CustTypeName , jumpE_basic.Valued , jumpE_basic.Copyable
	{
		public normal self;
		public string name()
		{
			return "bool";
		}
		public object getV()
		{
			return (self == normal.True) ? true  : false;
		}
		public object Copy()
		{
			return new Jbool(self);
		}
		public void change(normal d)
		{
			this.self = d;
		}
		public Jbool(normal n)
		{
			this.self = n;
		}
		public static void sett(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			normal that = normal.Default;
			if(equation[2] == "=")
			{
				if(equation[3] == "true")
				{
					that = normal.True;
				}
				else if(equation[3] == "false")
				{
					that = normal.False;
				}
				else if(equation[3] == "Null")
				{
					that = normal.Default;
				}
				else
				{
					bool q = jumpE_basic.base_runner.doMathbool(equation.Skip(3).ToArray(),D,Base);
					that = (q) ? normal.True : normal.False;
				}
			}
			D.setCustom("bool", equation[1],new Jbool(that));
		}
		public static void set(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			normal that = normal.Default;
			if(equation[1] == "!")
			{
				if(((Jbool)D.refrenceCustom("bool",equation[0])).self == normal.True)
					((Jbool)D.refrenceCustom("bool",equation[0])).change(normal.False);
				else if(((Jbool)D.refrenceCustom("bool",equation[0])).self == normal.False)
					((Jbool)D.refrenceCustom("bool",equation[0])).change(normal.True);
				return;
			}
			if(equation[1] == "=")
			{
				if(equation[2] == "true")
				{
					that = normal.True;
				}
				else if(equation[2] == "false")
				{
					that = normal.False;
				}
				else if(equation[2] == "Null")
				{
					that = normal.Default;
				}
				else
				{
					bool q = jumpE_basic.base_runner.doMathbool(equation.Skip(2).ToArray(),D,Base);
					that = (q) ? normal.True : normal.False;
				}
			}
			((Jbool)D.refrenceCustom("bool",equation[0])).change(that);
		}
		public override string ToString()
		{
			return (self == normal.True) ? "true" : (self == normal.False) ? "false" : "Null";
		}
		public static bool[] evaluateState(string[] equation,jumpE_basic.Data D,jumpE_basic.base_runner Base)
		{
			
			if(D.custtypeofkey(equation[2]) == "bool")
			{
				
				Jbool keyss = (Jbool)D.refrenceCustom("bool",equation[2]);
				if(keyss.self == normal.Default)
				{
					bool[] returnedstuff = new bool[]{false,(equation[1] == "nand" || equation[1] == "and")};
				}
				else
				{
					bool ppopp = (keyss.self == normal.True);
					bool oopoo = (equation[0] == "nand" || equation[0] == "and");
					bool[] returnedstuff = new bool[]{ (equation[0] == "nand"||equation[0]=="nor") ? !ppopp : ppopp , oopoo};
					return returnedstuff;
				}
				
			}
			
			
			return new bool[]{false,false};
		}
		
	}
	public class Special_bools : jumpE_basic.CustTypeName , jumpE_basic.Valued , jumpE_basic.Copyable
	{
		public special self;
		public string name()
		{
			return "Sbool";
		}
		public object getV()
		{
			return self;
		}
		public object Copy()
		{
			return new Sbool(self);
		}
		public void change(special d)
		{
			this.self = d;
		}
		public Jbool(special n)
		{
			this.self = n;
		}
		public static void sett(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			normal that = normal.Default;
			if(equation[2] == "=")
			{
				if(equation[3] == "true")
				{
					that = normal.True;
				}
				else if(equation[3] == "false")
				{
					that = special.False;
				}
				else if(equation[3] == "Null")
				{
					that = special.Default;
				}
				else if(equation[3] == "Neither"
				{
					that = special.Neither;
				}
				else
				{
					bool q = jumpE_basic.base_runner.doMathbool(equation.Skip(3).ToArray(),D,Base);
					that = (q) ? normal.True : normal.False;
				}
			}
			D.setCustom("bool", equation[1],new Jbool(that));
		}
		public static void set(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			normal that = normal.Default;
			if(equation[1] == "!")
			{
				if(((Jbool)D.refrenceCustom("bool",equation[0])).self == normal.True)
					((Jbool)D.refrenceCustom("bool",equation[0])).change(normal.False);
				else if(((Jbool)D.refrenceCustom("bool",equation[0])).self == normal.False)
					((Jbool)D.refrenceCustom("bool",equation[0])).change(normal.True);
				return;
			}
			if(equation[1] == "=")
			{
				if(equation[2] == "true")
				{
					that = normal.True;
				}
				else if(equation[2] == "false")
				{
					that = normal.False;
				}
				else if(equation[2] == "Null")
				{
					that = normal.Default;
				}
				else
				{
					bool q = jumpE_basic.base_runner.doMathbool(equation.Skip(2).ToArray(),D,Base);
					that = (q) ? normal.True : normal.False;
				}
			}
			((Jbool)D.refrenceCustom("bool",equation[0])).change(that);
		}
		public override string ToString()
		{
			return (self == normal.True) ? "true" : (self == normal.False) ? "false" : "Null";
		}
		public static bool[] evaluateState(string[] equation,jumpE_basic.Data D,jumpE_basic.base_runner Base)
		{
			
			if(D.custtypeofkey(equation[2]) == "bool")
			{
				
				Jbool keyss = (Jbool)D.refrenceCustom("bool",equation[2]);
				if(keyss.self == normal.Default)
				{
					bool[] returnedstuff = new bool[]{false,(equation[1] == "nand" || equation[1] == "and")};
				}
				else
				{
					bool ppopp = (keyss.self == normal.True);
					bool oopoo = (equation[0] == "nand" || equation[0] == "and");
					bool[] returnedstuff = new bool[]{ (equation[0] == "nand"||equation[0]=="nor") ? !ppopp : ppopp , oopoo};
					return returnedstuff;
				}
				
			}
			
			
			return new bool[]{false,false};
		}
		
	}
	

}