using UnityEngine;

namespace Unit
{
    public class MoveState : IState
    { 
        private readonly IInput _input;
        private readonly IMover _unit;
        private readonly ISwitcherState _switcherState;

        public MoveState(ISwitcherState switcherState, IInput input, IMover unit)
        {
            //Debug.Log("Инициализация Move");
            _input = input;
            _unit = unit;
            _switcherState = switcherState;
        }

        public void Update()
        {
            if (_input.MoveAxies == Vector2.zero)
                SwithToIdle();

            _unit.Move(_input.MoveAxies);
        }

        public void Enter()
        {
            _input.Enable();
            _input.Dashed += SwitchToDash;
           // Debug.Log("Move enter");
        }

        public void Exit()
        {
            _input.Dashed -= SwitchToDash;
            _input.Disable();
            //Debug.Log("Move exit");
        }

        private void SwithToIdle() => _switcherState.SwitchState<IdleState>("Move переходит в Idle");
        private void SwitchToDash() => _switcherState.SwitchState<DashState>("Move переходит в Dash");
    }
}
