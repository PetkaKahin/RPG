using System;
using UnityEngine;

namespace Unit
{
    public interface IMover
    {
        event Action Moved;

        void Move(Vector3 direction);
    }
}
