using System;

namespace StateMachine
{
    class FirstState : IState
    {
        StateMachine StateMachine;
        IState PrevState = null;

        public FirstState(StateMachine _StateMachine, IState state) => (StateMachine, PrevState) = (_StateMachine, state);

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
            StateMachine.CurrentState = new SecondState(stateMachine, this);
        }

        public void ReturnRoot()
        {
            StateMachine.CurrentState = new RootState(StateMachine);
        }
    }
}
