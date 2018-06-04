using Dorkbots.DorkbotsCommands;
using UnityEngine;

namespace CommandsExample
{
    public class ExampleSerialCommand : Command, ICommand, ICommandCallback
    {
        private SerialCommands serialCommands;

        public ExampleSerialCommand()
        {
            serialCommands = new SerialCommands();
        }

        protected override void ExecuteVirtual()
        {
            serialCommands.AddCallback(this);
            serialCommands.AddCommand(new ExampleCommand().Init(null, "Command encapsulated by another Command 1"));
            serialCommands.AddCommand(new ExampleCommand().Init(null, "Command encapsulated by another Command 2"));
            serialCommands.AddCommand(new ExampleCommand().Init(null, "Command encapsulated by another Command 3"));
            serialCommands.Execute();
        }

        public void CommandCompleted(ICommand command)
        {
            Debug.Log("<ExampleSerialCommand> Completed!");
            Complete();
        }

        protected override void DisposeVirtual()
        {
            base.DisposeVirtual();
        }
    }
}