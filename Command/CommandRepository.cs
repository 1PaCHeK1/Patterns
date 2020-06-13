using System.Collections.Generic;
using System.Linq;

namespace Command
{
    internal delegate void prefoperation();

    internal class CommandRepository
    {
        private List<ICommand> Commands;
        private Stack<prefoperation> PrefCommand;

        public CommandRepository()
        {
            Commands = new List<ICommand>();
            PrefCommand = new Stack<prefoperation>();
        }

        public void ExecuteCommand(int index)
        {
            if (index >= 0 && index < Commands.Count())
            {
                Commands[index].Execute();
                PrefCommand.Push(Commands[index].Undo);
            }
        }

        public void Undo()
        {
            if (PrefCommand.Count() > 0)
                PrefCommand.Pop()();
        }

        public void Add(ICommand command) => Commands.Add(command);
    }
}