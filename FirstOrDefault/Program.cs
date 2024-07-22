public class Grapes
{
    public int id {get; set;}
    public string Name {get; set;} = string.Empty;
}

public class Program
{
    public static void Main()
    {
        var grapesModel = new List<Grapes>
        {
           new Grapes {id = 1, Name = "giorgi"},
           new Grapes {id = 2, Name = "tato"} 
        };

        int IdtoInexd = 1;
        var result = grapesModel.FirstOrDefault(x => x.id == IdtoInexd);


        if (result != null)
        {
            Console.WriteLine($"found {result.Name}");
            var remove = grapesModel.Remove(result);
            if (remove)
            {
                Console.WriteLine($"Removed {result.Name}");
            }
        }
    }
}