namespace ConstructingClasses;

public class AulaConstructingClasses()
{
    public void DerivedException()
    {
        try
        {
            throw new DerivedException();
        }
        catch(DerivedException ex)
        {
            //Console.WriteLine("Source: {0}, Error: {1}", ex.Source, ex.Message);
            Console.WriteLine($"Source: {ex.Source}, Error: {ex.Message}");
        }
    }

    public void ConsumeGenericType()
    {
        //Add two string using the Obj class
        Obj oa = new Obj("Hello, ","World!");
        Console.WriteLine((string)oa.t + (string)oa.u);

        //Add two string using the Gen class
        Gen<string,string> ga = new Gen<string,string>("Hello, ","World!");
        Console.WriteLine(ga.t + ga.u);

        //Add a double and an int using the Obj class
        Obj ob = new Obj(10.125, 2005);
        Console.WriteLine((double)ob.t + (int)ob.u);

        //Add a double and an int using the Gen class
        Gen<double,int> gb = new Gen<double,int>(10.125,2005);
        Console.WriteLine(gb.t + gb.u);
    }
}

public class DerivedException : System.ApplicationException
{
    public override string Message
    {
        get { return "An error occurred in the application."; }
    }
}

public class BigClass : IDisposable
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}

public interface IMessage
{
    bool Send();
    string Message { get; set; }
    string Address { get; set; }
}

public class EmailMessage : IMessage
{
    public string Message { 
        get => throw new Exception("The method or operation is not implemented.");
        set => throw new Exception("The method or operation is not implemented."); 
    }
    public string Address { 
        get => throw new Exception("The method or operation is not implemented.");
        set => throw new Exception("The method or operation is not implemented."); 
    }

    public bool Send()
    {
        throw new Exception("The method or operation is not implemented.");
    }
}

public class Obj
{
    public Object t;
    public Object u;

    public Obj(Object _t, Object _u)    
    {
        this.t = _t;
        this.u = _u; 
    }
}

public class Gen<T,U>
{
    public T t;
    public U u;

    public Gen(T t, U u)
    {
        this.t = t;
        this.u = u;
    }
}

public class CompGen<T>
    where T : IComparable
{
    public T t1;
    public T t2;

    public CompGen(T _t1, T _t2)
    {
        this.t1 = _t1;
        this.t2 = _t2;
    }

    public T Max()
    {
        if(t2.CompareTo(this.t1) < 0)
            return t1;
        else
            return t2;
    }
}