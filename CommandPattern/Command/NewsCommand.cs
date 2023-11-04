public class NewsCommand: ICommand
{
    public void Execute()
    {
        Console.WriteLine("Campus interview will be organized on 25-May-23");
        Console.WriteLine("Inter college volley ball competion will be organized on 26-May-23");

    }

    public string GetDescription()
    {
        return "latest news";
    }

    
}
