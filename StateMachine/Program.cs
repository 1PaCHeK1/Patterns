using System;

namespace StateMachine
{
    class Program
    {
        static void Main()
        {
            StateMachine stateMachine = new StateMachine();
            stateMachine.RootState();
            stateMachine.GetContent();
            stateMachine.NextState();
            stateMachine.GetContent();
            stateMachine.NextState();
            stateMachine.GetContent();
            stateMachine.RootState();
            stateMachine.NextState();
            stateMachine.GetContent();

        }
    }
}
