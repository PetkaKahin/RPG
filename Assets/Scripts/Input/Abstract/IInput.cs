using System;
using UnityEngine;

public interface IInput
{
    bool IsMove { get; }

    event Action Moved;
    event Action Dashed;
    event Action LeftClicked;
    event Action RightClicked;

    Vector2 MoveAxies { get; }
    Vector2 MousePosition { get; }

    void Disable();
    void Enable();
}