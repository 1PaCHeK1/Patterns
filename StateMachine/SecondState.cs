using System;

namespace StateMachine
{
    class SecondState : IState
    {
        StateMachine StateMachine;
        IState PrevState = null;

        public SecondState(StateMachine _StateMachine, IState state) => (StateMachine, PrevState) = (_StateMachine, state);

        public void Content()
        {
            Console.WriteLine(this.GetType());
        }

        public void MoveBack()
        {
            StateMachine.CurrentState = PrevState;
        }

        public void MoveNext(StateMachine stateMachine, IState prevState)
        {
            PrevState = prevState;
            StateMachine.CurrentState = new RootState(stateMachine);
        }

        public void ReturnRoot()
        {
            StateMachine.CurrentState = new RootState(StateMachine);
        }

    }
}
