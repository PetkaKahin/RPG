using System;
using UnityEngine;

public interface IInput
{
    event Action<Vector2> Moved;

    Vector2 MoveAxies { get; }
}