using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;

namespace Unit
{
    public class UnitStateMachine : ISwitcherState
    {
        private readonly List<IState> _states = new List<IState>();
        private IState _currentState;

        public UnitStateMachine(List<IState> states = null)
        {
            if (states == null)
                return;

            _states = states;

            _currentState = _states[0];
            _currentState.Enter();
        }

        public void AddState<T>(IState state) where T : IState
        {
            if (state == null)
                throw new ArgumentNullException("Попытка присвоить null: " + nameof(state));

            /*IState newState = _states.FirstOrDefault(state => state is T);

            if (newState != null)
                throw new ArgumentException($"Попытка добавит уже существующие состояние: {newState}");*/

            _states.Add(state);
        }

        public void SwitchState<T>() where T : IState
        {
            IState state = _states.FirstOrDefault(state => state is T);

            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void Update() => _currentState.Update();
    }
}
