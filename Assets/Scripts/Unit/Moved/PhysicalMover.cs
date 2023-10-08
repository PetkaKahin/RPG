using System;
using UnityEngine;

namespace Unit
{
    public class PhysicalMover : BaseMover
    {
        private const float MassFactor = 250f;

        private Rigidbody2D _rigidbody;

        public PhysicalMover(IInput input, Rigidbody2D rigidbody = null) : base(input)
        {
            _rigidbody = rigidbody;
        }

        public override void BindTo(Rigidbody2D unit)
        {
            if (unit == null)
                throw new ArgumentNullException(nameof(unit));

            _rigidbody = unit;
        }

        public override void BindTo(Transform unit) { }

        public override void Move()
        {
            _rigidbody.AddForce(GetMoveNormalize() * _rigidbody.mass * MassFactor * Speed * Time.deltaTime);
        }
    }
}
