public partial class list : JEnumeral , CustTypeName 
{
    public string t;
	public string name()
	{
		return "list";
	}
    List<object> stuff;
    public list(string t)
    {
        this.t = t;
        stuff = new List<object>();
    }
    public void add(CustTypeName obj)
    {
        if (obj.name() == t)
        {
            stuff.Add(obj);
        }
        else
        {
            throw new ArgumentException("object is not of type " + t.ToString());
        }
    }
    public void remove(object obj)
    {
        if (GB.GetType(obj) == t)
        {
            stuff.Remove(obj);
        }
        else
        {
            throw new ArgumentException("object is not of type " + t.ToString());
        }
    }
    public void remove(int index)
    {
        stuff.RemoveAt(index);
    }
    public object get(int index)
    {
        return stuff[index];
    }
    public void set(int index, object obj)
    {
        if (GB.GetType(obj) != t)
        {
            throw new ArgumentException("object is not of type " + t.ToString());
        }
        stuff[index] = obj;
    }
    public int size()
    {
        return stuff.Count;
    }
    public void sort()
    {
        stuff.Sort();
    }
    public int find(object obj)
    {
        if (GB.GetType(obj) != t)
        {
            throw new ArgumentException("object is not of type " + t.ToString());
        }
        return stuff.IndexOf(obj);
    }
    public void clear()
    {
        stuff.Clear();
    }
    public override string ToString()
    {
        string returned = "[";
        for (int i = 0; i < size(); i++)
        {
            returned += stuff[i].ToString();
            if (i != size() - 1) returned += ",";
        }
        returned += "]";
        return returned;
    }

    public static list stringtolist(string a)
    {
        a = a.Substring(1, a.Length - 2);
        string[] parts = a.Split(',');
        list l = new list(parts[0]);
        for (int i = 1; i < parts.Length; i++)
        {
            l.add(parts[i]);
        }
        return l;
    }
    public static bool operator ==(list l1, list l2)
    {
        if (l1.size() != l2.size())
        {
            return false;
        }
        for (int i = 0; i < l1.size(); i++)
        {
            if (l1.get(i) != l2.get(i))
            {
                return false;
            }
        }
        return true;
    }
    public static bool operator !=(list l1, list l2)
    {
        if (l1.size() != l2.size())
        {
            return true;
        }
        for (int i = 0; i < l1.size(); i++)
        {
            if (l1.get(i) != l2.get(i))
            {
                return true;
            }
        }
        return false;
    }
    public static bool operator >(list l1, list l2)
    {
        if (l1.t != l2.t)
        {
            throw new ArgumentException("lists are not of the same type");
        }
        switch (l1.t.ToString())
        {
            case ("int"):
                if (l1.size() == l2.size())
                {
                    for (int i = 0; i < l1.size(); i++)
                    {
                        if ((int)l1.get(i) < (int)l2.get(i))
                        {
                            return false;
                        }
                    }
                }
                if (l1.size() > l2.size())
                {
                    return true;
                }
                break;
            case ("double"):
                if (l1.size() == l2.size())
                {
                    for (int i = 0; i < l1.size(); i++)
                    {
                        if ((double)l1.get(i) < (double)l2.get(i))
                        {
                            return false;
                        }
                    }
                }
                if (l1.size() > l2.size())
                {
                    return true;
                }
                break;
            case ("string"):
                if (l1.size() == l2.size())
                {
                    for (int i = 0; i < l1.size(); i++)
                    {
                        if (string.Compare((string)l1.get(i), (string)l2.get(i)) < 0)
                        {
                            return false;
                        }
                    }
                }
                if (l1.size() > l2.size())
                {
                    return true;
                }
                break;
            case ("list"):
                if (l1.size() == l2.size())
                {
                    for (int i = 0; i < l1.size(); i++)
                    {
                        if ((list)l1.get(i) < (list)l2.get(i))
                        {
                            return false;
                        }
                    }
                }
                if (l1.size() > l2.size())
                {
                    return true;
                }
                break;


        }

        return false;
    }
    public static bool operator <(list l1, list l2)
    {
        if (l1.size() < l2.size())
        {
            return true;
        }
        return false;
    }
    public static bool operator >=(list l1, list l2)
    {
        if (l1.size() >= l2.size())
        {
            return true;
        }
        return false;
    }
    public static bool operator <=(list l1, list l2)
    {
        if (l1.size() <= l2.size())
        {
            return true;
        }
        return false;
    }
    public bool Equals(list l)
    {
        if (this == l)
        {
            return true;
        }
        return false;
    }
}