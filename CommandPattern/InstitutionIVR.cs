public class InstitutionIVR
{
    
    List<ICommand> commands ;

    int exitChoice=0;

    public InstitutionIVR(List<ICommand> ivrCommands)
    {
        Console.WriteLine("Welcome to IVR");
        commands = ivrCommands;
        exitChoice = ivrCommands.Count() + 1;
        
    }

    public void AddCommand(ICommand command)
    {
        commands.Add(command);
    }

    public void RemoveCommand(ICommand command)
    {
        if (commands.Contains(command))
        {
            commands.Remove(command);
        }       
    }
    

    public void DisplayNavigation()
    {
        int i=0;
        for ( i = 0; i < commands.Count(); i++)
        {
            Console.WriteLine($"Press {i+1} for {commands[i].GetDescription()}");
        }        
        Console.WriteLine($"Press {exitChoice} for to exit");
    }

    public int GetExit()
    {
        return exitChoice;

    }

    public void Execute(int choice)
    {
        if (choice < exitChoice &&  choice  >  0)
        {
            commands[choice-1].Execute();
        }

    }
}