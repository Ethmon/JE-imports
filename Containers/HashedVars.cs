namespace HashedVars
{
	public class JByte :  jumpE_basic.CustTypeName , jumpE_basic.Number , jumpE_basic.Valued , jumpE_basic.Copyable, jumpE_basic.Hashable
	{
		byte self;
		public string name()
		{
			return "byte";
		}
		public void change(byte s)
		{
			this.self = s;
		}
		public double get_value()
		{
			return (double)self;
		}
		public object getV()
		{
			return self;
		}
		public object Copy()
		{
			return new JByte(self);
		}
		public byte[] hash()
		{
			return new byte[]{self};
		}
		public JByte(byte a)
		{
			this.self = a;
		}
		
		
		
		
		
		
		
		
		
		
		public static void sett(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			if(equation[2] == "=")
			{
				byte math = (byte)(jumpE_basic.base_runner.doMath(equation.Skip(3).ToArray(),D,Base));
				JByte j = new JByte(math);
				D.setCustom("byte",equation[1],j);
			}
			if (equation[2] == "BYT" && equation[3] == "=")
			{
				byte[] byt = (jumpE_basic.base_runner.dobyteMath(equation.Skip(4).ToArray(),D,Base));
				JByte j = new JByte(byt[0]);
				D.setCustom("byte",equation[1],j);
			}
		}
		public static object listSet(List<string> eq, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			byte math = 0;
			if(eq.Count() != 2)
				math = (byte)(jumpE_basic.base_runner.doMath(eq.Skip(2).ToArray(),D,Base));
			return new JByte(math);
		}
		public static void set(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			if(equation[1] == "BYT")
			{
				byte[] bb = {0};
				byte math = 0;
				if(equation.Count() != 3){
					bb = (jumpE_basic.base_runner.dobyteMath(equation.Skip(3).ToArray(),D,Base));
					math = bb[0];
				}
				switch(equation[2])
				{
					case "=":
						((JByte)D.refrenceCustom("byte",equation[0])).change(math);
						break;
					case "+=":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() + math));
						break;
					case "-=":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() - math));						
						break;
					case "*=":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() * math));
						break;
					case "/=":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() / math));
						break;
					case "++":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() + 1));						
						break;
					case "--":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() - 1));						
						break;
					case "**":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() * (byte)((JByte)D.refrenceCustom("byte", equation[0])).get_value()));						
						break;
					default:
						break;
						
				}
				
			}
			else {
				byte math = 0;
				if(equation.Count() != 2)
					math = (byte)(jumpE_basic.base_runner.doMath(equation.Skip(2).ToArray(),D,Base));
				switch(equation[1])
				{
					case "=":
						((JByte)D.refrenceCustom("byte",equation[0])).change(math);
						break;
					case "+=":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() + math));
						break;
					case "-=":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() - math));						
						break;
					case "*=":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() * math));
						break;
					case "/=":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() / math));
						break;
					case "++":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() + 1));						
						break;
					case "--":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() - 1));						
						break;
					case "**":
						((JByte)D.refrenceCustom("byte", equation[0])).change((byte)(((JByte)D.refrenceCustom("byte", equation[0])).get_value() * (byte)((JByte)D.refrenceCustom("byte", equation[0])).get_value()));						
						break;
					default:
						break;
						
				}
			}
		}
		
		
		
		
		
		
		
	}


	public class Jchar :  jumpE_basic.CustTypeName , jumpE_basic.Number , jumpE_basic.Valued , jumpE_basic.Copyable, jumpE_basic.Hashable
	{
		char self;
		public string name()
		{
			return "char";
		}
		public override string ToString()
		{
			return self.ToString();
		}
		public void change(char s)
		{
			this.self = s;
		}
		public double get_value()
		{
			return (double)self;
		}
		public object getV()
		{
			return self;
		}
		public object Copy()
		{
			return new Jchar(self);
		}
		public byte[] hash()
		{
			return new byte[]{(byte)self};
		}
		public Jchar(char a)
		{
			this.self = a;
		}
		
		public static void sett(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			if(equation[2] == "=")
			{
				
				Jchar j = new Jchar(equation[3][0]);
				D.setCustom("char",equation[1],j);
			}
			if (equation[2] == "BYT" && equation[3] == "=")
			{
				byte[] byt = (jumpE_basic.base_runner.dobyteMath(equation.Skip(4).ToArray(),D,Base));
				Jchar j = new Jchar((char)byt[0]);
				D.setCustom("char",equation[1],j);
			}
		}
		public static void set(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			if(equation[1] == "BYT")
			{
				byte[] bb = {0};
				char math = (char)0;
				if(equation.Count() != 3){
					bb = (jumpE_basic.base_runner.dobyteMath(equation.Skip(3).ToArray(),D,Base));
					math = (char)bb[0];
				}
				switch(equation[2])
				{
					case "=":
						((Jchar)D.refrenceCustom("char",equation[0])).change(math);
						break;
					case "+=":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() + math));
						break;
					case "-=":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() - math));						
						break;
					case "*=":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() * math));
						break;
					case "/=":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() / math));
						break;
					case "++":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() + 1));						
						break;
					case "--":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() - 1));						
						break;
					case "**":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() * (char)((Jchar)D.refrenceCustom("char", equation[0])).get_value()));						
						break;
					default:
						break;
						
				}
				
			}
			else {
				char math = (char)0;
				if(equation.Count() != 2)
					math = (char)(jumpE_basic.base_runner.doMath(equation.Skip(2).ToArray(),D,Base));
				switch(equation[1])
				{
					case "=":
						((Jchar)D.refrenceCustom("char",equation[0])).change(math);
						break;
					case "+=":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() + math));
						break;
					case "-=":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() - math));						
						break;
					case "*=":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() * math));
						break;
					case "/=":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() / math));
						break;
					case "++":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() + 1));						
						break;
					case "--":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() - 1));						
						break;
					case "**":
						((Jchar)D.refrenceCustom("char", equation[0])).change((char)(((Jchar)D.refrenceCustom("char", equation[0])).get_value() * (char)((Jchar)D.refrenceCustom("char", equation[0])).get_value()));						
						break;
					default:
						break;
						
				}
			}
		}
		
		
		

	}
	



}