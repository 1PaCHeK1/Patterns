namespace StateMachine
{
    interface IState
    {
        void Content();
        void ReturnRoot();
        void MoveBack();
        void MoveNext(StateMachine stateMachine, IState prevState);
    }
}