using System;
using UnityEngine;

public class DescktopInput : IInput
{
    private readonly InputSystem _input;

    public Vector2 MoveAxies => _input.Moving.Move.ReadValue<Vector2>();
    public bool IsMove => MoveAxies != Vector2.zero;

    public event Action Moved; 
    public event Action Dashed;

    public DescktopInput()
    {
        _input = new InputSystem();

        _input.Moving.Dash.started += ctx => Dash();
        _input.Moving.Move.started += ctx => Move();

        Enable();
    }

    public void Disable() => _input.Disable();

    public void Enable() => _input.Enable();

    private void Dash() => Dashed?.Invoke();

    private void Move() => Moved?.Invoke();
}
