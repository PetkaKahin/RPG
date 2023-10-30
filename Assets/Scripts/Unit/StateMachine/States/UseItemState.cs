using Items;

namespace Unit
{
    public class UseItemState : IState
    {
        private readonly ISwitcherState _switcherState;
        private readonly IItem _item;

        public UseItemState(ISwitcherState switcherState, IItem item)
        {
            _switcherState = switcherState;
            _item = item;
        }

        public void Enter()
        {
            _item.UseCompleted += SwitchToIdle;
            _item.Use();
        }

        public void Exit()
        {
            _item.UseCompleted -= SwitchToIdle;
        }

        public void Update()
        {
            
        }

        private void SwitchToIdle() => _switcherState.SwitchState<IdleState>();
    }
}
