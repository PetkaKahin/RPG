using System.Collections.Generic;

namespace Unit
{
    public class UnitStateMachine
    {
        private List<IState> _states = new List<IState>();
        private IState _currentState;

        public UnitStateMachine()
        {
            
        }

        public void AddState(IState state)
        {

        }
    }
}
