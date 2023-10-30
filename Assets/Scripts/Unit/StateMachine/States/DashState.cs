using DG.Tweening;
using UnityEngine;

namespace Unit
{
    public class DashState : IState
    {
        private readonly IMovable _unit;
        private readonly ISwitcherState _switcherState;
        private readonly IInput _input;
        private readonly DashConfig _config;

        public DashState(ISwitcherState switcherState, IMovable unit, IInput input, DashConfig config)
        {
            _switcherState = switcherState;
            _unit = unit;
            _input = input;
            _config = config;
        }

        public void Enter()
        {
            Vector3 direction = ((Vector3)_input.MousePosition - _unit.Transform.position).normalized;
            _unit.Transform.DOMove(_unit.Transform.position + direction * _config.Distance, _config.Time).onComplete += SwitchToIdle;
        }

        public void Exit() { }

        public void Update() { }

        private void SwitchToIdle() => _switcherState.SwitchState<IdleState>();
    }
}
