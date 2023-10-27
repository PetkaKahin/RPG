using System;
using UnityEngine;

namespace Items
{
    [CreateAssetMenu(fileName = "SwordConfig", menuName = "Configs/Weapon/Sword")]
    public class SwordConfig : ScriptableObject
    {
        [SerializeField] private float _damage;
        [SerializeField] private float _timeAttack;
        [SerializeField] private float _range;
        [SerializeField] private float _angleAttack;

        public float Damage => _damage;
        public float TimeAttack => _timeAttack;
        public float Range => _range;
        public float AngleAttack => _angleAttack;

        public void SetDamage(float damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            _damage = damage;
        }
    }
}
