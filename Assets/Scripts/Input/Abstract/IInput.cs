using System;
using UnityEngine;

public interface IInput
{
    bool IsMove { get; }

    event Action Moved;
    event Action Dashed;

    Vector2 MoveAxies { get; }

    void Disable();
    void Enable();
}