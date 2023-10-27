using Items;

namespace Unit
{
    public class UseItemState : IState
    {
        private readonly ISwitcherState _switcherState;
        private readonly IItem _weapon;

        public UseItemState(ISwitcherState switcherState, IItem item)
        {
            _switcherState = switcherState;
            _weapon = item;
        }

        public void Enter()
        {
            _weapon.UseCompleted += SwitchToIdle;
            _weapon.Use();
        }

        public void Exit()
        {
            _weapon.UseCompleted -= SwitchToIdle;
        }

        public void Update()
        {
            
        }

        private void SwitchToIdle() => _switcherState.SwitchState<IdleState>();
    }
}
