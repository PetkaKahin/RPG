using System;

namespace Unit
{
    public class UnitHealth : IDamagable, IHeal
    {
        public const float MinHealth = IHeath.MinHealth;

        public event Action Healed;
        public event Action Died;

        public float MaxHealth { get; private set; }
        public float Health { get; private set; }

        public UnitHealth(float maxHealth)
        {
            SetMaxHealth(maxHealth);
            Health = MaxHealth;
        }

        public void Heal(float value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            Health += value;

            if (Health > MaxHealth)
                Health = MaxHealth;

            Healed?.Invoke();
        }

        public void TakeDamage(float damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            Health -= damage;

            if (Health < MinHealth)
                Die();
        }

        public void SetMaxHealth(float maxHealth)
        {
            if (maxHealth < MinHealth)
                throw new ArgumentOutOfRangeException(nameof(maxHealth));

            MaxHealth = maxHealth;
        }

        private void Die()
        {
            Died?.Invoke();
        }
    }
}
