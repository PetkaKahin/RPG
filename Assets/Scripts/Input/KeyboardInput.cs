using System;
using UnityEngine;

public class KeyboardInput : IInput
{
    private readonly InputSystem _input;

    public KeyboardInput() 
    {
        _input = new InputSystem();
    }

    public Vector2 MoveAxies => GetInputMove();

    public event Action<Vector2> Moved;

    public void Disable() => _input.Disable();

    public void Enable() => _input.Enable();

    private Vector2 GetInputMove()
    {
        Vector2 direction = _input.Moving.Move.ReadValue<Vector2>();

        if (IsMove(direction))
            Moved?.Invoke(direction);
        
        return direction;
    }

    private bool IsMove(Vector2 direction) => direction != Vector2.zero;
}
