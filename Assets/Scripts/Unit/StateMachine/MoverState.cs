using Zenject;

namespace Unit
{
    public class MoverState : IState
    {
        private IInput _input;

        [Inject]
        public MoverState(IInput input)
        {
            _input = input;
        }

        public void Enter()
        {

        }

        public void Exit()
        {

        }
    }
}
