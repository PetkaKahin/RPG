namespace Unit
{
    public interface ISwitcherState
    {
        void SwitchState<T>() where T : IState;
    }
}
