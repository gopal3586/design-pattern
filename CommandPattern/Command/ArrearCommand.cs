public class ArrearCommand: ICommand
{
    
    public ArrearCommand()
    {
        
    }
    public void Execute()
    {
        Console.WriteLine("Enter registration no.");
        string? regNo = Console.ReadLine();
        Console.WriteLine($"The student {regNo} has no arrears");

    }

    public string GetDescription()
    {
        return "arrear details";
    }
}