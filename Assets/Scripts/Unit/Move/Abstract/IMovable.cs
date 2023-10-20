using UnityEngine;

namespace Unit
{
    public interface IMovable
    {
        Transform Transform { get; }
        float Speed { get; }

        void SetSpeed(float speed);
    }
}
