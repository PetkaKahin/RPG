using UnityEngine;

namespace Unit
{
    [CreateAssetMenu(fileName = "DashConfig", menuName = "Configs/Unit/Dash")]
    public class DashConfig : ScriptableObject
    {
        [SerializeField] private float _distance;
        [SerializeField] private float _time;

        public float Distance => _distance;
        public float Time => _time;
    }
}
