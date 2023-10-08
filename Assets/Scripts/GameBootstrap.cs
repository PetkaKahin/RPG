using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    [SerializeField, Range(-1, 240)] private int _targetFrameRate;

    private void Awake()
    {
        Application.targetFrameRate = _targetFrameRate;
    }
}
