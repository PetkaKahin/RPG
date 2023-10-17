using UnityEngine;
using System;

namespace Unit
{
    public class MoveState : IState
    {
        private const float MassFactor = 250f;

        private readonly IInput _input;
        private readonly IMovable _unit;
        private readonly ISwitcherState _switcherState;
        private readonly Rigidbody2D _unitRigidbody;

        public MoveState(ISwitcherState switcherState, IInput input, IMovable unit)
        {
            _input = input;
            _unit = unit;
            _switcherState = switcherState;

            _unitRigidbody = _unit.GetRigidbody();
        }

        public void Update()
        {
            if (_input.MoveAxies == Vector2.zero)
                _switcherState.SwitchState<IdleState>();

            _unitRigidbody.AddForce(_input.MoveAxies * MassFactor * _unit.Speed * Time.deltaTime);
        }

        public void Enter()
        {
            _input.Enable();
            Debug.Log("MoveState");
        }

        public void Exit()
        {
            _input.Disable();
        }
    }
}
