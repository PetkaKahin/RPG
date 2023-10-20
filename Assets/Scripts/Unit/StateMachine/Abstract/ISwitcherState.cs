namespace Unit
{
    public interface ISwitcherState
    {
        void SwitchState<T>(string message) where T : IState;
    }
}
