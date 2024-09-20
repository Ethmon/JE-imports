
namespace io
{

		
		public class Standard_In
		{
			public static string Lat;
			public static int LatK;
			public static void StIn(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
			{
				jumpE_basic.base_runner.print(equation, D, Base);
				Lat = Console.ReadLine();
			}
			public static void Key(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
			{
				jumpE_basic.base_runner.print(equation, D, Base);
				LatK = Console.Read();
			}
			public static string[] Last(string[] E, Data D, base_runner B, int I, int K)
			{
				return new string[]{Lat , "0"};
			}
			
			public static string[] LastK(string[] E, Data D, base_runner B, int I, int K)
			{
				return new string[] {LatK.ToString(),"0"};
			}
			
			public static void readFile(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
			{
				string filepath = $"{jumpE_basic.base_runner.currentPath}\\{equation[1]}";
				string contents = File.ReadAllText(filepath);
				Lat = contents;
				
			}
			
		}
		
		public class Standard_Out
		{
			
			public static string sent_out;
			public static void VarOut(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
			{
				if(D.referenceVar(equation[1]) is jumpE_basic.Valued)
				{
					sent_out = (((jumpE_basic.Valued)D.referenceVar(equation[1])).getV().ToString());
					//Console.WriteLine($"sucsess:  {sent_out}");
				}
				//else Console.WriteLine("failure");
				
			}
			public static void display(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
			{
				Console.Clear();
				Console.Write(sent_out);
			}
			public static void WriteOut(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
			{
				string filepath = $"{jumpE_basic.base_runner.currentPath}\\{equation[1]}";
				//Console.WriteLine(filepath);
				File.WriteAllText(filepath,sent_out);
			}
			
			
			
		}
	
	
}