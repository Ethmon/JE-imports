namespace JMath
{


	public class trig
	{
		public static string[] SINE(string[] E, jumpE_basic.Data D, jumpE_basic.base_runner B, int I, int K)
		{
			double theta = 0;
			int skip = 1;
			if(D.isnumvar(E[I+1]))
			{
				theta = ((jumpE_basic.Number)(D.referenceVar(E[I+1]))).get_value();
			}
			else if (double.TryParse(E[I+1], out double k))
			{
				theta = k;
			}
			else if(jumpE_basic.base_runner.Mathss.Keys.Contains(E[I+1]))
			{
				string[] bbb = jumpE_basic.base_runner.Mathss[E[I+1]](E,D,B,I+1,K);
				skip += int.Parse(bbb[1]);
				theta = double.Parse(bbb[0]);
				
			}
			theta = Math.Sin(theta);
			string[] returned = {theta.ToString(),skip.ToString()};
			return returned;
		}
		
		
		public static string[] COSINE(string[] E, jumpE_basic.Data D, jumpE_basic.base_runner B, int I, int K)
		{
			double theta = 0;
			int skip = 1;
			if(D.isnumvar(E[I+1]))
			{
				theta = ((jumpE_basic.Number)(D.referenceVar(E[I+1]))).get_value();
			}
			else if (double.TryParse(E[I+1], out double k))
			{
				theta = k;
			}
			else if(jumpE_basic.base_runner.Mathss.Keys.Contains(E[I+1]))
			{
				string[] bbb = jumpE_basic.base_runner.Mathss[E[I+1]](E,D,B,I+1,K);
				skip += int.Parse(bbb[1]);
				theta = double.Parse(bbb[0]);
				
			}
			
			theta = Math.Cos(theta);
			string[] returned = {theta.ToString(),skip.ToString()};
			return returned;
		}
		
		
		
		public static string[] TANGENT(string[] E, jumpE_basic.Data D, jumpE_basic.base_runner B, int I, int K)
		{
			double theta = 0;
			int skip = 1;
			if(D.isnumvar(E[I+1]))
			{
				theta = ((jumpE_basic.Number)(D.referenceVar(E[I+1]))).get_value();
			}
			else if (double.TryParse(E[I+1], out double k))
			{
				theta = k;
			}
			else if(jumpE_basic.base_runner.Mathss.Keys.Contains(E[I+1]))
			{
				string[] bbb = jumpE_basic.base_runner.Mathss[E[I+1]](E,D,B,I+1,K);
				skip += int.Parse(bbb[1]);
				theta = double.Parse(bbb[0]);
				
			}
			
			theta = Math.Tan(theta);
			string[] returned = {theta.ToString(),skip.ToString()};
			return returned;
		}
		
		
		
		
		
		
		public static string[] COSEC(string[] E, jumpE_basic.Data D, jumpE_basic.base_runner B, int I, int K)
		{
			double theta = 0;
			int skip = 1;
			if(D.isnumvar(E[I+1]))
			{
				theta = ((jumpE_basic.Number)(D.referenceVar(E[I+1]))).get_value();
			}
			else if (double.TryParse(E[I+1], out double k))
			{
				theta = k;
			}
			else if(jumpE_basic.base_runner.Mathss.Keys.Contains(E[I+1]))
			{
				string[] bbb = jumpE_basic.base_runner.Mathss[E[I+1]](E,D,B,I+1,K);
				skip += int.Parse(bbb[1]);
				theta = double.Parse(bbb[0]);
				
			}
			theta = 1 / Math.Sin(theta);
			string[] returned = {theta.ToString(),skip.ToString()};
			return returned;
		}
		
		
		public static string[] SEC(string[] E, jumpE_basic.Data D, jumpE_basic.base_runner B, int I, int K)
		{
			double theta = 0;
			int skip = 1;
			if(D.isnumvar(E[I+1]))
			{
				theta = ((jumpE_basic.Number)(D.referenceVar(E[I+1]))).get_value();
			}
			else if (double.TryParse(E[I+1], out double k))
			{
				theta = k;
			}
			else if(jumpE_basic.base_runner.Mathss.Keys.Contains(E[I+1]))
			{
				string[] bbb = jumpE_basic.base_runner.Mathss[E[I+1]](E,D,B,I+1,K);
				skip += int.Parse(bbb[1]);
				theta = double.Parse(bbb[0]);
				
			}
			
			theta = 1 / Math.Cos(theta);
			string[] returned = {theta.ToString(),skip.ToString()};
			return returned;
		}
		
		
		
		public static string[] COTAN(string[] E, jumpE_basic.Data D, jumpE_basic.base_runner B, int I, int K)
		{
			double theta = 0;
			int skip = 1;
			if(D.isnumvar(E[I+1]))
			{
				theta = ((jumpE_basic.Number)(D.referenceVar(E[I+1]))).get_value();
			}
			else if (double.TryParse(E[I+1], out double k))
			{
				theta = k;
			}
			else if(jumpE_basic.base_runner.Mathss.Keys.Contains(E[I+1]))
			{
				string[] bbb = jumpE_basic.base_runner.Mathss[E[I+1]](E,D,B,I+1,K);
				skip += int.Parse(bbb[1]);
				theta = double.Parse(bbb[0]);
				
			}
			
			theta = 1 / Math.Tan(theta);
			string[] returned = {theta.ToString(),skip.ToString()};
			return returned;
		}
		
		
	}

}