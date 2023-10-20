using System;
using UnityEngine;

public class KeyboardInput : IInput
{
    private readonly InputSystem _input;

    public Vector2 MoveAxies => _input.Moving.Move.ReadValue<Vector2>();

    public event Action Moved;
    public event Action Dashed;

    public KeyboardInput()
    {
        _input = new InputSystem();

        _input.Moving.Dash.started += ctx => Dash();
        _input.Moving.Move.started += ctx => Move();
    }

    public void Disable() => _input.Disable();

    public void Enable() => _input.Enable();

    private void Dash()
    {
        Debug.Log("Pressed: F");
        Dashed?.Invoke();
    }

    private void Move()
    {
        Debug.Log("Pressed: WASD");
        Moved?.Invoke();
    }
}
