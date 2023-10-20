using System;
using UnityEngine;

public class ClassicInput : IInput
{
    private const string HorizontalAxisName = "Horizontal";
    private const string VerticalAxisName = "Vertical";

    public Vector2 MoveAxies => GetInputAxies();

    public event Action Moved;
    public event Action Idled;
    public event Action Dashed;

    public void Disable() { }

    public void Enable() { }

    private Vector2 GetInputAxies()
    {
        Vector2 axies = Vector2.zero;

        axies.x = Input.GetAxis(HorizontalAxisName);
        axies.y = Input.GetAxis(VerticalAxisName);

        Moved?.Invoke();

        return axies;
    }
}

