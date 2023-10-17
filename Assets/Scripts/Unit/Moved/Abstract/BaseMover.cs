using System;
using UnityEngine;

namespace Unit
{
    public abstract class BaseMover : IMover
    {
        protected const float MaxDirection = 1f;

        protected readonly IInput Input;

        public float Speed { get; protected set; } = 5f;

        public BaseMover(IInput input)
        {
            Input = input;
            Input.Enable();
        }

        public virtual void BindTo(Transform unit) { }

        public virtual void BindTo(Rigidbody2D unit) { }

        public virtual void Move() { }

        public virtual void SetSpeed(float value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            Speed = value;
        }

        protected virtual Vector2 GetMoveNormalize() 
        {
            Vector3 direction = Input.MoveAxies;

            if (direction.magnitude > MaxDirection)
                direction.Normalize();

            return direction;
        }
    }
}
