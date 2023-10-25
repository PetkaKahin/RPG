using UnityEngine;
using Unit;
using System;

namespace Weapon
{
    [RequireComponent(typeof(CapsuleCollider2D))]
    public class Sword : MonoBehaviour, IDamager
    {
        [SerializeField] private SwordConfig _config;

        private CapsuleCollider2D _sword;

        public float Damage => _config.Damage;

        public event Action AttackCompleted;

        private void Start()
        {
            _sword = GetComponent<CapsuleCollider2D>();
            Disable();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Enemy enemy))
            {
                enemy.Health.TakeDamage(Damage);
                Debug.Log($"Damage({Damage}) to {collision.name}({enemy.Health.Value})");
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
                Attack();
        }

        public void Attack()
        {
            Enable();
            Invoke(nameof(Disable), _config.TimeAttack);
        }

        public void SetDamage(float damage) => _config.SetDamage(damage);

        private void Enable() => _sword.enabled = true;
        private void Disable()
        {
            _sword.enabled = false;
            AttackCompleted?.Invoke();
        }
    }
}
