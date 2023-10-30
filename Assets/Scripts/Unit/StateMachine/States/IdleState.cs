namespace Unit
{
    public class IdleState : IState
    {
        private readonly ISwitcherState _switcherState;
        private readonly IInput _input;
        private readonly IMover _mover;

        public IdleState(ISwitcherState switcherState, IInput input, IMover mover) 
        {
            _switcherState = switcherState;
            _input = input;
            _mover = mover;
        }

        public void Enter()
        {
            _input.Moved += SwitchToMove;
            _input.Dashed += SwitchToDash;
            _input.LeftClicked += SwichToUseItem;
        }

        public void Exit()
        {
            _input.Moved -= SwitchToMove;
            _input.Dashed -= SwitchToDash;
            _input.LeftClicked -= SwichToUseItem;
        }

        public void Update() 
        {
            if (_input.IsMove)
                SwitchToMove();

            _mover.RotateTo(_input.MousePosition);
        }

        private void SwitchToMove() => _switcherState.SwitchState<MoveState>();
        private void SwitchToDash() => _switcherState.SwitchState<DashState>();
        private void SwichToUseItem() => _switcherState.SwitchState<UseItemState>();
    }
}
