// EDIT THIS CODE SO IT ACTUALLY IS FORMATED FOR THE JE INTERPRETER



namespace SheetsPlus
{

	public class ASheet : jumpE_basic.Data , jumpE_basic.CustTypeName
	{
		public ISet<string> Locked = new HashSet<string>();
		public Dictionary<string,SMethod> methods = new Dictionary<string,SMethod>();
		public string name()
		{
			return "ASheet";
		}
		public static void Aside(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
					
			ASheet data = new ASheet();

			if ((equation[1] == "\"" && equation[3] == "\"") && D.referenceVar(equation[2]) is jumpE_basic.Valued)
			{
			
				D.setCustom("ASheet",D.referenceVar(equation[2]).ToString(),data);
			}
			else
			{
				D.setCustom("ASheet",equation[1],data);
			}
			Base.datas.Add(data);
		
		}
		public static void Acall(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			if ((equation[1] == "\"" && equation[3] == "\"") && D.referenceVar(equation[2]) is Valued)
			{
				Base.datas.Add((ASheet)(D.referenceVar(((Valued)D.referenceVar(equation[2])).getV().ToString())));
			}
			else if (D.referenceVar(equation[1]) is ASheet)
			{
				Base.datas.Add((ASheet)(D.referenceVar(equation[1])));
			}
		}
		public static void Apush(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			
		}
		/*
		>M>  {ASheet} {name}
		*/
		public static void MethodCall(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			jumpE_basic.Data cur = D;
			for(int i = 1;i<equation.Count()-1;i++)
				if(cur.isvar(equation[i])&&cur.referenceVar(equation[i]) is jumpE_basic.Data)
					cur = (jumpE_basic.Data)cur.referenceVar(equation[i]);
			if(cur is ASheet)
				((ASheet)cur).methods[equation[equation.Count()-1]].CALL();
			else
				throw new Exception("not a valid Sheet");
		}
		/*
		format for how a method will look
		M>> {name}
		code
		code
		code
		M<<
		*/
		public static void BeginMethod(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			string Lines = "";
			int amountoflines = 1;
			for(int i = Base.position+1; i < Base.lines.Count(); i++)
			{
				amountoflines++;
				if(jumpE_basic.base_runner.SimpleTokenizer.no_tab_spaces(Base.lines[i]) != "M<<")
					Lines += Base.lines[i] + "\n";
				else
					break;
			}
			Base.position += amountoflines;
			if(D is ASheet)
				if(((ASheet)D).methods.ContainsKey(equation[1]))
					((ASheet)D).methods.Add(equation[1],new SMethod(Lines,(ASheet)D));
				else
					((ASheet)D).methods[equation[1]] = new SMethod(Lines,(ASheet)D);
			
			else throw new Exception("not in an ASheet");
		}
		/*
		this is how you would return from a method early
		M>>
		
		<M<
		print HI \n
		M<<
		*/
		public static void ReturnFromMethod(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			
			
		}
		public static void  LockVar(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			if(((ASheet)D).keys.Contains(equation[1]))
				((ASheet)D).Locked.Add(equation[1]);
		}
		public static void UnlockVar(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
		{
			if(((ASheet)D).Locked.Contains(equation[1]))
				((ASheet)D).Locked.Remove(equation[1]);
		}
		

	}
	
	
	public class SMethod
	{
		public string content;
		public ASheet Layer;
		public SMethod()
		{
		}
		public SMethod(string con,ASheet a)
		{
			content = con;
			Layer = a;
		}
		public void CALL()
		{
			new jumpE_basic.base_runner(content + "\nend", Layer, jumpE_basic.base_runner.currentPath);
			
		}
	}
}

