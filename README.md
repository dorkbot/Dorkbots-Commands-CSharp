# Dorkbots-Commands-CSharp
Dorkbots Commands is a flexible framework for creating and running parallel and serial commands.

This is taken from the example Unity project included in the repos. You can see the code in the example of a state command -> https://github.com/dorkbot/-Dorkbots-Commands-CSharp/blob/master/Examples/Dorkbots-Commands%20Unity%20Example/Assets/Scripts/CommandsExample/ExampleCommandStateOne.cs

// add a single command to the root commands
rootCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 1"));

// added parallel commands to the root
ParallelCommands parallelCommands = new ParallelCommands();
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 2"));
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 3"));
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 4"));
rootCommands.AddCommand(parallelCommands);

parallelCommands = new ParallelCommands();

// add serial commmands to parallel commands then add to root
SerialCommands serialCommands = new SerialCommands();
serialCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 5"));
serialCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 6"));
serialCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 7"));
parallelCommands.AddCommand(serialCommands);

// add serial commmands to parallel commands then add to root
serialCommands = new SerialCommands();
serialCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 8"));
serialCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 9"));
serialCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 10"));
parallelCommands.AddCommand(serialCommands);

// add serial commmands to parallel commands then add to root
rootCommands.AddCommand(parallelCommands);

serialCommands = new SerialCommands();

// Add parallel commands to serial commands then add to root
parallelCommands = new ParallelCommands();
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 11"));
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 12"));
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 13"));
serialCommands.AddCommand(parallelCommands);

// Add parallel commands to serial commands then add to root
parallelCommands = new ParallelCommands();
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 14"));
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 15"));
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 16"));
serialCommands.AddCommand(parallelCommands);

// Add parallel commands to serial commands then add to root
rootCommands.AddCommand(serialCommands);

// add parallel commands to the root
parallelCommands = new ParallelCommands();
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 17"));
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 18"));
parallelCommands.AddCommand(new ExampleCommandMonoBehaviour().Init(monoBehaviourObject, null, "Command 19"));

rootCommands.AddCommand(parallelCommands);

// add the lighter commands that don't have the built in reference to a MonoBehaviour Object
rootCommands.AddCommand(new ExampleCommand().Init(null, "Command 20"));

rootCommands.Excute();

http://www.dorkbots.com/repositories/commands

Author: Dayvid jones
http://www.dayvid.com
Copyright (c) Superhero Robot 2018
http://www.SuperheroRobot.com
