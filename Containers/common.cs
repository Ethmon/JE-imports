namespace common
{
	public class Jint : jumpE_basic.CustTypeName , jumpE_basic.Number , jumpE_basic.Valued , jumpE_basic.Copyable
	{
		int self;
		// public byte[]  jumpE_basic.Hashable.hash()
		// {
			// return new byte[] {(byte)self};//Array.Reverse(BitConverter.GetBytes(self));
		// }
		public static int Dehash(byte[] d)
		{
			return (int)d[0];//ToInt32(d);
		}
		public object Copy()
		{
			return new Jint(self);
		}
		public string name()
		{
			return "int";
		}
		public override string ToString()
		{
			return self.ToString();
		}
		public object getV()
		{
			return self;
		}
		public double get_value()
		{
			return self;
		}
		public void change(int vale)
		{
			this.self = vale;
		}
		public Jint(int a)
		{
			this.self = a;
		}
		public static void sett(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			int math = (int)(jumpE_basic.base_runner.doMath(equation.Skip(3).ToArray(),D,Base));
			Jint j = new Jint(math);
			switch(equation[2])
			{
				case "=":
					D.setCustom("int",equation[1],j);
					break;
				default:
					break;
			}
		}
		public static void set(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			int math = 0;
			if(equation.Count() != 2)
				math = (int)(jumpE_basic.base_runner.doMath(equation.Skip(2).ToArray(),D,Base));
			switch(equation[1])
			{
				case "=":
					((Jint)D.refrenceCustom("int",equation[0])).change(math);
					break;
				case "+=":
					((Jint)D.refrenceCustom("int",equation[0])).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()+math);
					break;
				case "-=":
					((Jint)D.refrenceCustom("int",equation[0])).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()-math);
					break;
				case "*=":
					((Jint)D.refrenceCustom("int",equation[0])).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()*math);
					break;
				case "/=":
					((Jint)D.refrenceCustom("int",equation[0])).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()/math);
					break;
				case "++":
					((Jint)D.refrenceCustom("int",equation[0])).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()+1);
					break;
				case "--":
					((Jint)D.refrenceCustom("int",equation[0])).change((int)((Jint)D.refrenceCustom("int",equation[0])).get_value()-1);
					break;
				case "**":
					((Jint)D.refrenceCustom("int",equation[0])).change((int)(((Jint)D.refrenceCustom("int",equation[0])).get_value()*((Jint)D.refrenceCustom("int",equation[0])).get_value()));
					break;
				default:
					break;
					
			}
		}
		
	}



	public class Jdouble : jumpE_basic.CustTypeName , jumpE_basic.Number , jumpE_basic.Valued , jumpE_basic.Copyable
	{
		double self;
		// public byte[]  jumpE_basic.Hashable.hash()
		// {
			// return new byte[] {(byte)self};//Array.Reverse(BitConverter.GetBytes(self));
		// }
		public static double Dehash(byte[] d)
		{
			return (int)d[0];//ToInt32(d);
		}
		public object Copy()
		{
			return new Jdouble(self);
		}
		public override string ToString()
		{
			return self.ToString();
		}
		public string name()
		{
			return "double";
		}
		public object getV()
		{
			return self;
		}
		public double get_value()
		{
			return self;
		}
		public void change(double vale)
		{
			this.self = vale;
		}
		public Jdouble(double a)
		{
			this.self = a;
		}
		public static void sett(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			double math = (jumpE_basic.base_runner.doMath(equation.Skip(3).ToArray(),D,Base));
			Jdouble j = new Jdouble(math);
			switch(equation[2])
			{
				case "=":
					D.setCustom("double",equation[1],j);
					break;
				default:
					break;
			}
		}
		public static void set(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			double math = 0;
			if(equation.Count()!=2)
				math = (jumpE_basic.base_runner.doMath(equation.Skip(2).ToArray(),D,Base));
			switch(equation[1])
			{
				case "=":
					((Jdouble)D.refrenceCustom("double",equation[0])).change(math);
					break;
				case "+=":
					((Jdouble)D.refrenceCustom("double",equation[0])).change(((Jdouble)D.refrenceCustom("double",equation[0])).get_value()+math);
					break;
				case "-=":
					((Jdouble)D.refrenceCustom("double",equation[0])).change(((Jdouble)D.refrenceCustom("double",equation[0])).get_value()-math);
					break;
				case "*=":
					((Jdouble)D.refrenceCustom("double",equation[0])).change(((Jdouble)D.refrenceCustom("double",equation[0])).get_value()*math);
					break;
				case "/=":
					((Jdouble)D.refrenceCustom("double",equation[0])).change(((Jdouble)D.refrenceCustom("double",equation[0])).get_value()/math);
					break;
				case "++":
					((Jdouble)D.refrenceCustom("double",equation[0])).change(((Jdouble)D.refrenceCustom("double",equation[0])).get_value()+1);
					break;
				case "--":
					((Jdouble)D.refrenceCustom("double",equation[0])).change(((Jdouble)D.refrenceCustom("double",equation[0])).get_value()-1);
					break;
				case "**":
					((Jdouble)D.refrenceCustom("double",equation[0])).change((((Jdouble)D.refrenceCustom("double",equation[0])).get_value()*((Jdouble)D.refrenceCustom("double",equation[0])).get_value()));
					break;
				default:
					break;
					
			}
		}
		
	}


	public class Jstring : jumpE_basic.CustTypeName , jumpE_basic.Valued, jumpE_basic.Copyable
	{
		string self = "";
		public string name()
		{
			return "string";
		}
		public object Copy()
		{
			return new Jstring(self);
		}
		public object getV()
		{
			return self;
		}
		public override string ToString()
		{
			return self.ToString();
		}
		public Jstring(string j)
		{
			self = j;
		}
		public static string Dehash(byte[] d)
		{
			 return Encoding.UTF8.GetString(d);
		}
		public byte[] hash()
		{
			return Encoding.UTF8.GetBytes(self);
		}
		public static void sett(List<string> code, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			string Message = "";
			for(int i = 3;i<code.Count();i++)
			{
				if (code[i] == "\\n")
	{
		Message += "\n";
	}
	else if (code[i] == "\"" && code[i + 2] == "\"")
	{

		var msg = (D.referenceVar(code[i + 1]));
		if (msg.GetType() == typeof(list))
		{
			Message += ((list)msg).ToString();
		}
		else Message += msg;
		i += 2;
	}
	else if (jumpE_basic.base_runner.Mathss.ContainsKey(code[i]))
	{
		string[] bbb = jumpE_basic.base_runner.Mathss[code[i]](code.ToArray(), D, Base, i, 0);
		Message += bbb[0];
		i += int.Parse(bbb[1]);

	}
	else if (code[i] == "M#" && code[i + 1] == "#")
	{

		List<string> codess = new List<string>();
		for (int ll = i+2; ll < code.Count; ll++)
		{
			if (code[ll] == "#" && code[ll + 1] == "#M")
			{
				i = ll + 1;
				break;
			}
			codess.Add(code[ll]);
		}
		Message += jumpE_basic.base_runner.doMath(codess.ToArray(), D, Base);
	}
	else if (code[i] == "B#" && code[i + 1] == "#")
	{

		List<string> codess = new List<string>();
		for (int ll = i; ll < code.Count; ll++)
		{
			if (code[ll] == "#" && code[ll + 1] == "#B")
			{
				i = ll + 1;
				break;
			}
			codess.Add(code[ll]);
		}
		Message += jumpE_basic.base_runner.doMathbool(codess.ToArray(), D, Base).ToString();
	}
	else
	{
		Message += code[i];
	}
	
			}
			Jstring NN = new Jstring(Message);
			switch(code[2])
			{
				case "=":
					D.setCustom("string",code[1],NN);
					break;
				default:
					break;
			}
		}
		public static void set(List<string> code, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			
		{
			string Message = "";
			for(int i = 2;i<code.Count();i++)
			{
				if (code[i] == "\\n")
	{
		Message += "\n";
	}
	else if (code[i] == "\"" && code[i + 2] == "\"")
	{

		var msg = (D.referenceVar(code[i + 1]));
		if (msg.GetType() == typeof(list))
		{
			Message += ((list)msg).ToString();
		}
		else Message += msg;
		i += 2;
	}
	else if (jumpE_basic.base_runner.Mathss.ContainsKey(code[i]))
	{
		string[] bbb = jumpE_basic.base_runner.Mathss[code[i]](code.ToArray(), D, Base, i, 0);
		Message += bbb[0];
		i += int.Parse(bbb[1]);

	}
	else if (code[i] == "M#" && code[i + 1] == "#")
	{

		List<string> codess = new List<string>();
		for (int ll = i+2; ll < code.Count; ll++)
		{
			if (code[ll] == "#" && code[ll + 1] == "#M")
			{
				i = ll + 1;
				break;
			}
			codess.Add(code[ll]);
		}
		Message += jumpE_basic.base_runner.doMath(codess.ToArray(), D, Base);
	}
	else if (code[i] == "B#" && code[i + 1] == "#")
	{

		List<string> codess = new List<string>();
		for (int ll = i; ll < code.Count; ll++)
		{
			if (code[ll] == "#" && code[ll + 1] == "#B")
			{
				i = ll + 1;
				break;
			}
			codess.Add(code[ll]);
		}
		Message += jumpE_basic.base_runner.doMathbool(codess.ToArray(), D, Base).ToString();
	}
	else
	{
		Message += code[i];
	}
			}
			switch(code[1])
			{
				case "=":
					D.setCustom("string",code[0],new Jstring(Message));
					break;
				case "+=":
					D.setCustom("string", code[0],new Jstring(((Jstring)D.refrenceCustom("string",code[0])).getV()+Message));
					break;
				default:
					break;
			}
		}
		}
		
		
	public static string[] SIZEOF(string[] E, Data D, base_runner B, int I, int K)
	{
		int count = -1;
		// Console.Write("SIZEOF INSIDE");
		if(D.referenceVar(E[I+1]) is Jstring)
		{
			// Console.Write("This is stupid");
			Jstring ddd = (Jstring)D.refrenceCustom("string",E[I+1]);
			count = ddd.getV().ToString().Length;
		}
		// Console.Write(count + " this is maby working");
		string[] aaa = {count.ToString(),"1"};
		// Console.Write(aaa[0] + "    " + aaa[1] + "\n");
		return aaa;
			
	}
	public static string[] AAT(string[] E, Data D, base_runner B, int I, int K)
		{
			
			if(D.referenceVar(E[I+1]) is Jstring)
			{
				// Console.Write("DKJNG");
				Jstring ddd = (Jstring)D.refrenceCustom("string",E[I+1]);
				// Console.Write("HASLKDH");
				string jkj = ddd.getV().ToString();
				
				// Console.Write("JDKFDJLFJ");
				//string jkj = ddd.getV();
				int d = 0;
				if(D.isnumvar(E[I+2]))
				{
					d = (int)(((jumpE_basic.Number)D.referenceVar(E[I+2])).get_value());
				}else if(int.TryParse(E[I+2],out int dd))
				{
					d = dd;
				}
				if(E[I+3] != "|")
				{
					int sds = 0;
					string jj = "";
					if(D.isnumvar(E[I+3]))
					{
						sds = (int)(((jumpE_basic.Number)D.referenceVar(E[I+3])).get_value());
						jj = jkj.Substring(d,sds);
					}else if(int.TryParse(E[I+3],out int dddd))
					{
						sds = dddd;
						jj = jkj.Substring(d,sds);
					}
					else if(E[I+3] == "->|")
					{
						sds = jkj.Length-d;
						jj = jkj.Substring(d,sds);
					}
					else if(E[I+3] == "Val")
					{
						jj = ((int)((jkj[d]))).ToString();
					}
					string[] fff = {jj,"4"};
					return fff;
					
				}
				else{
				string[] fff = {jkj.Substring(d,d),"3"};
				return fff;
				}
			}
			Console.Write("ERROR");
			string[] ffff = {"0","0"};
			return ffff;
		}
		public static bool operator ==(Jstring a, Jstring b)
		{
			 return (a.ToString() == b.ToString());
		}
		public static bool operator !=(Jstring a, Jstring b)
		{
			return (a.ToString() != b.ToString());
		}
		public bool Equals(object a)
		{
			if ( a is Jstring)
			{
				return (((Jstring)a) == this);
			}
			return false;
		}
	}

}