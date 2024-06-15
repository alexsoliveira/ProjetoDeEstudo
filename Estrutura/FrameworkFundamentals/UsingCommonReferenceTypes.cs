using System.Text;

namespace UsingCommonReferenceTypes;

public class AulaUsingCommonReferenceTypes()
{
    public void StructTypeValue()
    {
        Numbers number1 = new Numbers(0);
        Numbers number2 = number1;
        number1.val+= 1;
        number2.val+= 2;
        Console.WriteLine("number1 = {0}, number2 = {1}", number1, number2);
    }

    public void StringsAndStringBuilders()
    {
        string text = "this is some text to search"; 
        text = text.Replace("search", "replace"); 
        Console.WriteLine(text);

        string text2; 
 
        text2 = "wombat"; // "wombat" 
        text2 += " kangaroo"; // "wombat kangaroo" 
        text2 += " wallaby"; // "wombat kangaroo wallaby" 
        text2 += " koala"; // "wombat kangaroo wallaby koala" 
        Console.WriteLine(text2);

        StringBuilder sb = new StringBuilder(30); 
        sb.Append("wombat"); // Build string. 
        sb.Append(" kangaroo"); 
        sb.Append(" wallaby"); 
        sb.Append(" koala"); 
        string text3 = sb.ToString(); // Copy result to string. 
        Console.WriteLine(text3);
    }

    public void CreateSortArrays()
    {
        // Declare and initialize an array. 
        int[] array = { 3, 1, 2 }; 
        
        // Call a shared/static array method. 
        Array.Sort(array); 
        
        // Display the result. 
        Console.WriteLine("{0}, {1}, {2}", array[0], array[1], array[2]);
    }

    public void UseStreams()
    {
        // Create and write to a text file 
        StreamWriter sw = new StreamWriter("text.txt"); 
        sw.WriteLine("Hello, World!"); 
        sw.Close(); 
        
        // Read and display a text file 
        StreamReader sr = new StreamReader("text.txt"); 
        Console.WriteLine(sr.ReadToEnd()); 
        sr.Close();
    }

    public void CatchExceptions()
    {
        try 
        { 
            StreamReader sr1 = new StreamReader(@"C:\boot.ini"); 
            Console.WriteLine(sr1.ReadToEnd()); 
        } 
        catch (Exception ex) 
        { 
            // If there are any problems reading the file, display an error message 
            Console.WriteLine("Error reading file: " + ex.Message); 
        }

        try 
        { 
            StreamReader sr2 = new StreamReader("text.txt"); 
            Console.WriteLine(sr2.ReadToEnd()); 
        } 
        catch (System.IO.FileNotFoundException) 
        { 
            Console.WriteLine("The file could not be found."); 
        }
        catch (System.UnauthorizedAccessException) 
        { 
            Console.WriteLine("You do not have sufficient permissions."); 
        } 
        catch (Exception ex) 
        { 
            Console.WriteLine("Error reading file: " + ex.Message); 
        }

        StreamReader sr = new StreamReader("text.txt"); 
        try 
        { 
            Console.WriteLine(sr.ReadToEnd()); 
        } 
        catch (Exception ex) 
        { 
            // If there are any problems reading the file, display an error message 
            Console.WriteLine("Error reading file: " + ex.Message); 
        } 
        finally 
        { 
            // Close the StreamReader, whether or not an exception occurred 
            sr.Close(); 
        }
    }

    public void ListValueTypes()
    {
        SByte a = 0; 
        Byte b = 0; 
        Int16 c = 0; 
        Int32 d = 0; 
        Int64 e = 0; 
        string s = ""; 
        Exception ex = new Exception();

        Object[] types = { a, b, c, d, e, s, ex };

        foreach(Object o in types)
        {
            string type;
            if(o.GetType().IsValueType)
            {
                type = "Value type";
            }
            else
            {
                type = "Reference Type";
            }
            Console.WriteLine("{0}: {1}", o.GetType(), type);

        }
    }

    public void SortString()
    {
        string s = "Microsoft .NET Framework Application Developmnt Foundation";
        string[] sa = s.Split(' ');

        Array.Sort(sa);

        s = string.Join(" ", sa);
        Console.WriteLine(s);
    }

    public void WorkWithStreamsAndExceptions()
    {
        try
        {
            TextReader tr = new StreamReader("text2.txt");
            try
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                tr.Close();
            }
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("Sorry, the file does not exist.");
        }
        catch (System.UnauthorizedAccessException)
        {
            Console.WriteLine("Sorry, you lack sufficient privileges.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

struct Numbers
{
    public int val;

    public Numbers(int _val)
    {
        this.val = _val;
    }

    public override string ToString()
    {
        return val.ToString();
    }

}