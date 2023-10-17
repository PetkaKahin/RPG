using UnityEngine;

namespace Unit
{
    public interface IMovable
    {
        float Speed { get; }

        void SetSpeed(float speed);

        Rigidbody2D GetRigidbody();
        Transform GetTransform();
    }
}
