using Weapon;

namespace Unit
{
    public class AttackState : IState
    {
        private readonly ISwitcherState _switcherState;
        private readonly IDamager _weapon;

        public AttackState(ISwitcherState switcherState, IDamager weapon)
        {
            _switcherState = switcherState;
            _weapon = weapon;
        }

        public void Enter()
        {
            _weapon.AttackCompleted += SwitchToIdle;
            _weapon.Attack();
        }

        public void Exit()
        {
            _weapon.AttackCompleted -= SwitchToIdle;
        }

        public void Update()
        {
            
        }

        private void SwitchToIdle() => _switcherState.SwitchState<IdleState>();
    }
}
