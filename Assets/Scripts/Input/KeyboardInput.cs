using System;
using UnityEngine;

public class KeyboardInput : IInput
{
    private readonly InputSystem _input;

    public KeyboardInput() 
    {
        _input = new InputSystem();
        _input.Enable();
    }

    public Vector2 MoveAxies => GetInputMove();

    public event Action<Vector2> Moved;

    private Vector2 GetInputMove()
    {
        Vector2 direction = _input.Moving.Move.ReadValue<Vector2>();
        Moved?.Invoke(direction);

        return direction;
    }
}
