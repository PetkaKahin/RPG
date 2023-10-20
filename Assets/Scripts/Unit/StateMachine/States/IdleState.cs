using UnityEngine;

namespace Unit
{
    public class IdleState : IState
    {
        private readonly ISwitcherState _switcherState;
        private readonly IInput _input;

        public IdleState(ISwitcherState switcherState, IInput input) 
        {
            //Debug.Log("Инициализация Idle");
            _switcherState = switcherState;
            _input = input;
        }

        public void Enter()
        {
            _input.Enable();
            _input.Moved += SwitchToMove;
            _input.Dashed += SwitchToDash;
            //Debug.Log("Idle enter");
        }

        public void Exit()
        {
            _input.Moved -= SwitchToMove;
            _input.Dashed -= SwitchToDash;
            _input.Disable();
            //Debug.Log("Idle exit");
        }

        public void Update()
        {
            
        }

        private void SwitchToMove() => _switcherState.SwitchState<MoveState>("Idle переходит в Move");
        private void SwitchToDash() => _switcherState.SwitchState<DashState>("Idle переходит в Dash");
    }
}
