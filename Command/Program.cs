namespace Command
{
    class Program
    {
        /// <summary>
        /// Здесь мы реализуем паттерн Команда
        /// </summary>
        static void Main()
        {
            var CommandRepositorys = new CommandRepository();
            CommandRepositorys.Add(new CommandClass1(new Class1() { Value = 1 }));

            CommandRepositorys.ExecuteCommand(0);
            CommandRepositorys.ExecuteCommand(0);

            CommandRepositorys.Undo();
            CommandRepositorys.Undo();
            CommandRepositorys.Undo();
            CommandRepositorys.Undo();

            CommandRepositorys.ExecuteCommand(0);
            CommandRepositorys.ExecuteCommand(0);
            CommandRepositorys.ExecuteCommand(0);
            CommandRepositorys.Undo();
            CommandRepositorys.ExecuteCommand(0);
            CommandRepositorys.ExecuteCommand(0);

        }
    }
}
