// See https://aka.ms/new-console-template for more information




List<ICommand> commands =  new List<ICommand>();
commands.Add(new AttendenceCommand());
commands.Add(new ArrearCommand());
commands.Add(new NewsCommand());


InstitutionIVR  ivr =  new InstitutionIVR(commands);
int userChoice = ivr.GetExit();

//After a call is received

do {
    ivr.DisplayNavigation();
    
    userChoice =  Convert.ToInt32( Console.ReadLine());
    Console.Clear();
    ivr.Execute(userChoice);
    
} while(userChoice  !=  ivr.GetExit());

