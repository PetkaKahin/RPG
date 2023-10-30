using System;
using UnityEngine;

public class DescktopInput : IInput
{
    private readonly Camera _camera;
    private readonly InputSystem _input;

    public Vector2 MoveAxies => _input.Moving.Move.ReadValue<Vector2>();
    public Vector2 MousePosition => _camera.ScreenToWorldPoint(Input.mousePosition);

    public bool IsMove => MoveAxies != Vector2.zero;

    public event Action Moved;
    public event Action Dashed;
    public event Action LeftClicked;
    public event Action RightClicked;

    public DescktopInput()
    {
        _camera = Camera.main;

        _input = new InputSystem();

        _input.Moving.Dash.started += ctx => Dash();
        _input.Moving.Move.started += ctx => Move();

        _input.Mouse.LeftMouseButton.started += ctx => LeftClicked?.Invoke();
        _input.Mouse.RightMouseButton.started += ctx => RightClicked?.Invoke();

        _input.Mouse.LeftMouseButton.started += ctx => UseItem();

        Enable();
    }

    public void Disable() => _input.Disable();
    public void Enable() => _input.Enable();

    private void Dash() => Dashed?.Invoke();
    private void Move() => Moved?.Invoke();

    private void UseItem() => Debug.Log("Use item");
}
