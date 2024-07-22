using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

public class SecondTry
{
    public int Id {get; set;}
    public string Name {get; set;} = string.Empty;
}


public class Program
{
    public static void Main()
    {
        var stack = new List<SecondTry>
        {
            new SecondTry {Id = 2, Name = "giorgio"},
            new SecondTry {Id = 3, Name = "gela"}
        };
        int IdtoIndex = 3;
        var Result = stack.FirstOrDefault(x => x.Id == IdtoIndex);
        
        if (Result != null)
        {
            Console.WriteLine($"Found: {Result.Name}");
        }
        else 
        {
           Console.WriteLine("nop!"); 
        }
    }
}