using UnityEngine;
using System;

namespace Unit
{
    public class TransformMover : IMover
    {
        private IMovable _unit;

        public float Speed => _unit.Speed;

        public event Action Moved;

        public TransformMover(IMovable unit)
        {
            _unit = unit;
        }

        public void Move(Vector3 direction)
        {
            _unit.Transform.position += direction * Speed * Time.deltaTime;
            Moved?.Invoke();
        }
    }
}
