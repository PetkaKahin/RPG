namespace Unit
{
    public class IdleState : IState
    {
        private readonly ISwitcherState _switcherState;
        private readonly IInput _input;

        public IdleState(ISwitcherState switcherState, IInput input) 
        {
            _switcherState = switcherState;
            _input = input;
        }

        public void Enter()
        {
            _input.Moved += SwitchToMove;
            _input.Dashed += SwitchToDash;
        }

        public void Exit()
        {
            _input.Moved -= SwitchToMove;
            _input.Dashed -= SwitchToDash;
        }

        public void Update() 
        {
            if (_input.IsMove)
                SwitchToMove();
        }

        private void SwitchToMove() => _switcherState.SwitchState<MoveState>();
        private void SwitchToDash() => _switcherState.SwitchState<DashState>();
    }
}
