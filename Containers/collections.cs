namespace collections
{
	
	{
			public class node<T> : jumpE_basic.CustTypeName , jumpE_basic.Valued
					{
						public T Data;
						public node<T> nextnode;
						public string name()
						{
							return "node"
						}
						public object getV()
						{
							return nextnode;
						}
						public node(T data)
						{
							This.Data = data;
							nextnode = null;
						}
					}
						
			public class LikedList<T> : jumpE_basic.CustTypeName , jumpE_basic.Valued
					{
				private node<T> Head;
				private node<T> Last;
				public LikedList(T data)
				{
					Head = new node<T>(data);
					Last = Head;
				}
				public object getV()
				{
					return Head;
				}
				public string name()
				{
					return "linked-list";
				}
				public LikedList()
				{
					Head = null;
					Last = null;
				}
				public void add(T data)
				{
					var newnode = node<T>(data);
					if(Head == null){
						Head = newnode;
						Last = newnode;
					}
					else
					{
						Node<T> cur = Last;
						while(cur.nextnode != null)
							cur = cur.nextnode;
						cur.nextnode = newnode;
						Last = newnode;
					}
					
				}
				public static void set(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
					{
						if(equation==3)
						{
							D.setCustom("linked-list",equation[1],new LikedList());
						}
						
					}
				public static void sett(List<string> equation, jumpE_basic.Data D, jumpE_basic.base_runner Base)
				{
					if(equation[1] == "add")
					{
						var cur = D.refrenceCustom("linked-list",equation[0]);
						cur.add(D.refrenceVar(equation[2]));
					}
				}
				
			}
	}

}
