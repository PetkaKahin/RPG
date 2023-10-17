using UnityEngine;

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
            _input.Enable();
            _input.Moved += SwitchState;
            Debug.Log("IdleState");
        }

        public void Exit()
        {
            _input.Disable();
            _input.Moved -= SwitchState;
        }

        public void Update()
        {
            Vector2 direction = _input.MoveAxies;
        }

        private void SwitchState(Vector2 direction)
        {
            _switcherState.SwitchState<MoveState>();
        }
    }
}
