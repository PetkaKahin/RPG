using System;
using UnityEngine;

public interface IInput
{
    event Action Moved;
    event Action Dashed;

    Vector2 MoveAxies { get; }

    void Disable();
    void Enable();
}