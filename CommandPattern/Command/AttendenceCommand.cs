
public class AttendenceCommand: ICommand
{
    
    public AttendenceCommand()
    {
        
    }
    
    public void Execute()
    {       
        Console.WriteLine("Enter registration no.");
        string? regNo = Console.ReadLine();         
        Console.WriteLine($"The student {regNo} is present today");   
    }
    public string GetDescription()
    {
        return "current day presence";
    }
}