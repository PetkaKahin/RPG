using UnityEngine;
using System;

namespace Unit
{
    public class TransformMover : IMover
    {
        private const float AngleOffset = 90f;

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

        public void RotateTo(Vector3 direction)
        {
            Vector3 target = _unit.Transform.position - direction;
            float angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;
            _unit.Transform.rotation = Quaternion.Euler(0f, 0f, angle + AngleOffset);
        }
    }
}
