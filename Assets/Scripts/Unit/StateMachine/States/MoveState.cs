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
            _input = input;
            _unit = unit;
            _switcherState = switcherState;
        }

        public void Update()
        {
            Vector2 direction = _input.MoveAxies;

            if (direction == Vector2.zero)
                SwithToIdle();

            _unit.Move(direction);
        }

        public void Enter()
        {
            _input.Dashed += SwitchToDash;
            _input.LeftClicked += SwichToAttack;
        }

        public void Exit()
        {
            _input.Dashed -= SwitchToDash;
            _input.LeftClicked -= SwichToAttack;
        }

        private void SwithToIdle() => _switcherState.SwitchState<IdleState>();
        private void SwitchToDash() => _switcherState.SwitchState<DashState>();
        private void SwichToAttack() => _switcherState.SwitchState<AttackState>();
    }
}
