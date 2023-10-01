using System;
using UnityEngine;

namespace Unit
{
    public class BaseMover : IMover
    {
        protected readonly Transform UnitTransform;
        protected readonly IInput Input;

        public float Speed { get; protected set; }

        public BaseMover(Transform unit, IInput input, float speed = 5)
        {
            Input = input;
            Speed = speed;
            UnitTransform = unit;
        }

        public virtual void Move()
        {
            UnitTransform.position += (Vector3)Input.Axies * Speed * Time.deltaTime;
        }

        public virtual void SetSpeed(float value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            Speed = value;
        }
    }
}
