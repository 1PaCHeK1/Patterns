namespace StateMachine
{
    class StateMachine
    {
        public StateMachine() => CurrentState = new RootState(this);

        public IState CurrentState { get; set; }
        
        public void NextState()
        {
            CurrentState.MoveNext(this, CurrentState);
        }
        public void BackState()
        {
            CurrentState.MoveBack();
        }
        public void RootState()
        {
            CurrentState.ReturnRoot();
        }
        public void GetContent()
        {
            CurrentState.Content();
        }
    }
}
