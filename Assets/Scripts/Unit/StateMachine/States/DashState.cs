using DG.Tweening;
using UnityEngine;

namespace Unit
{
    public class DashState : IState
    {
        private readonly IMovable _unit;
        private readonly ISwitcherState _switcherState;

        private float _distance = 3f;
        private float _time = 0.1f;

        public DashState(ISwitcherState switcherState, IMovable unit)
        {
            //Debug.Log("Инициализация Dash");
            _switcherState = switcherState;
            _unit = unit;
        }

        public void Enter()
        {
            //Debug.Log("Dash enter");

            _unit.Transform.position += Vector3.up * _distance;
            SwitchToIdle();
        }

        public void Exit()
        {
            // Debug.Log("Dash exit");
            
        }

        public void Update() { }

        private void SwitchToIdle() => _switcherState.SwitchState<IdleState>("Dash переходит в Idle");
    }
}
