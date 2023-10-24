using System;
using UnityEngine;

namespace Unit
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/Player")]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] private float _heath;
        [SerializeField] private float _speed;

        public float Health => _heath;
        public float Speed => _speed;

        public void SetSpeed(float speed)
        {
            if (speed < 0)
                throw new ArgumentOutOfRangeException(nameof(speed));

            _speed = speed;
        }
    }
}
