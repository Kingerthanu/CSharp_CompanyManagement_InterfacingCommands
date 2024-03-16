public class Driver
{

    public static void Main(string[] args)
    {

        // If we have no inputs we can just return as nothing to do.
        if(args.Length == 0)
        {
            Console.WriteLine("No File Provided; Our Demo File Commands Are in \"_demoCommands.txt\".");
            return;
        }

        Console.WriteLine("\n\nDemo will demonstrate 5 tasks; each of varying difficulty and skill amount. We will have 4 difficulty-10 skills, each with their own varying curve.\n" +
            "Our known company will create 4 teams, each with a ever-increasing amount of employees on each; starting at 0 employees associated.\n" +
            "After seeing changes that we expect to see from larger team sets like a usual decrease in runtime (unless get a drag of a teammate which slows down runtime [quite impredictable with rand. of hireOperation]),\n" +
            "we will then move employees around teams to then see if these transfer operations work properly by moving teammates to a previously empty team to populate it.\n" +
            "The demo will end by removing all employees from a team our final statement should express all our estimations as NaN.\n");


        Console.WriteLine("Initializing Variables: ");

        Console.WriteLine(" Creating 4, level-10 Difficulty Skills: \n" +
            "    Skill 1 [Linear]\n" +
            "    Skill 1 [Adjusted x 2]\n" +
            "    Skill 2 [Randomized]\n" +
            "    Skill 3 [Adjusted x 2]");

        // Create three skills of unique curve.
        Skill[] taskSkillSetBuffer =
        {

            new Skill("Skill 1", "David Soggins", true, 10),                                    //  Linear             Skill 1
            new Skill("Skill 1", "David Brappins", true, 10, new AdjustedDifficultyCurve(2.0f)), // Adjustedx2         Skill 1
            new Skill("Skill 2", "Wet Towel", true, 10, new RandomizedDifficultyCurve()),       //  Randomized         Skill 2
            new Skill("Skill 3", "Pastrami", true, 10, new AdjustedDifficultyCurve(2.0f))       //  Adjustedx2         Skill 3

        };

        Console.WriteLine(" Creating 5 Tasks: \n" +
             "    Task One: None (Baseline Skill Difficulty)\n" +
             "    Task Two: Linear\n" +
             "    Task Three: Adjustedx2 [Skill 1]\n" +
             "    Task Four: Linear, Randomized\n" +
             "    Task Five: Linear, Randomized, Adjustedx2 [Skill 3]");

        Task[] tasksToDo =
        {

            new Task("Task One: None (Baseline Skill Difficulty)", "The", 60.0f),
            new Task("Task Two: Linear (Skill 1 no adjusted curve)", "The Most Task Ever", 60.0f, [taskSkillSetBuffer[0]]),
            new Task("Task Three: Adjustedx2 [Skill 1]", "The Task Ever", 60.0f, [taskSkillSetBuffer[1]]),
            new Task("Task Four: Linear, Randomized", "The Most Task Ever-est", 60.0f, [taskSkillSetBuffer[0], taskSkillSetBuffer[2]]),
            new Task("Task Five: Linear, Randomized, Adjustedx2 [Skill 3]", "The Most Task Ever-est-est", 60.0f, [ taskSkillSetBuffer[0], taskSkillSetBuffer[2], taskSkillSetBuffer[3] ])
            
        };

        Console.WriteLine(" Creating Company, Mann-Co\n");

        Company MANNCO = new Company("Mann-Co");

        Console.WriteLine("Done Initializing Variables.\n");

        

        // Read File...
        string filename = args[0];

        Console.WriteLine("Reading " + filename);

        string[] lines = System.IO.File.ReadAllLines(filename);

        List<IOrgChange> changes = new List<IOrgChange>();

        foreach (string line in lines){

            string[] parts = line.Split(' ');

            char operation = parts[0][0];
            string name = parts[1];

            string teamName = parts.Length > 2 ? parts[2] : null;

            if (operation == 'h')
            {
                Console.WriteLine("  " + (changes.Count + 1) + ".) Operation Create Employee:  " + name);
                changes.Add(new HireOperation(name));
            }
            else if (operation == 'c')
            {
                Console.WriteLine("  " + (changes.Count + 1) + ".) Operation Create Team:  " + name);
                changes.Add(new CreateTeamOperation(name));
            }
            else if (operation == 't')
            {
                Console.WriteLine("  " + (changes.Count + 1) + ".) Operation Dissolve and Transfer Employee Teams:  " + name + "  to  " + teamName);
                changes.Add(new TransferOperation(name, teamName));
            }

        }

        Console.WriteLine("Done Reading.\n\n");
        Console.WriteLine("Now Applying Changes to " + MANNCO.Name + "...\n");

        Console.WriteLine("Expected Behaivor is the following: \n" +
            "  1.) Create 1st Team: GreyMann\n" +
            "  2.) Create 2nd Team: BluTarch\n" +
            "  3.) Create 3rd Team: Redmond\n" +
            "  4.) Create 4th Team: Zepheniah\n" +
            "  5.) Hire Employee: Agnoli\n" +
            "  6.) Hire Employee: Cristian\n" +
            "  7.) Hire Employee: Cooper\n" +
            "  8.) Hire Employee: Perry\n" +
            "  9.) Hire Employee: Porter\n" +
            "  10.) Hire Employee: Preston\n" +
            "  11.) Put Agnoli on Team BluTarch\n" +
            "  12.) Put Cristian on Team Redmond\n" +
            "  13.) Put Cooper on Team Redmond\n" +
            "  14.) Put Perry on Team Zepheniah\n" +
            "  15.) Put Porter on Team Zepheniah\n" +
            "  16.) Put Preston on Team Zepheniah\n" +
            "  17.) Remove Preston from Team Zepheniah and Move to Team GreyMann\n" +
            "  18.) Remove Porter from Team Zepheniah and Move to Team GreyMann\n" +
            "  19.) Remove Perry from Team Zepheniah and Move to Team GreyMann\n" +
            "  20.) Remove Preston from Team GreyMann\n" +
            "  21.) Remove Porter from Team GreyMann\n" +
            "  22.) Remove Perry from Team GreyMann\n" +
            "  23.) Remove Cooper from Team Redmond\n" +
            "  24.) Remove Cristian from Team Redmond\n" +
            "  25.) Remove Agnoli from Team BluTarch"
            );

        // Apply changes to the company
        for (int i = 0; i < changes.Count; i++)
        {

            Console.WriteLine("\n Change " + (i+1) + " being applied...");

            changes[i].Apply(MANNCO);

            // Print each Team's cost estimate for each Task
            foreach (var team in MANNCO.Teams)
            {

                Console.WriteLine("    Team " + team.Name + "'s Estimations: ");

                foreach (var task in tasksToDo)
                {
                    Console.WriteLine($"       Cost estimate for Task '{task.Name}' for Team '{team.Name}': { team.estimateTask(task) }");
                }

                Console.WriteLine();

            }

        }


        Console.WriteLine("Done Applying Changes to " + MANNCO.Name + "\n\n");
        
    }

}
