using UnityEngine;

namespace Unit
{
    public interface IMover
    {
        float Speed { get; }

        void BindTo(Transform unit);
        void BindTo(Rigidbody2D unit);

        void SetSpeed(float value);
        void Move();
    }
}