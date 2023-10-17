using System;
using UnityEngine;

namespace Unit
{
    public class ClassicMover : BaseMover
    {
        private Transform _unitTransform;

        public ClassicMover(IInput input) : base(input) { }

        public override void BindTo(Transform unit)
        {
            if (unit == null)
                throw new ArgumentNullException(nameof(unit));

            if (_unitTransform == null)
                _unitTransform = unit;
        }

        public override void Move()
        {
            _unitTransform.position += (Vector3)GetMoveNormalize() * Speed * Time.deltaTime;
        }
    }
}
