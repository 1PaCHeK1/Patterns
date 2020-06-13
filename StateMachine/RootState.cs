using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    class RootState : IState
    {
        StateMachine StateMachine;

        public RootState(StateMachine _StateMachine) => StateMachine = _StateMachine;

        public void MoveBack()
        {
            Console.WriteLine("Вы на главном экране");
        }

        public void Content()
        {
            Console.WriteLine(this.GetType());
        }

        public void MoveNext(StateMachine stateMachine, IState prevState)
        {
            stateMachine.CurrentState = new FirstState(stateMachine, this);
        }

        public void ReturnRoot()
        {
            Console.WriteLine("Вы и так на главном экране");
        }
        
    }
}
