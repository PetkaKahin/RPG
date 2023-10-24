using System;

namespace Unit
{
    public class UnitHealth : IDamagable, IHeal
    {
        public const float MinValue = IHeath.MinValue;

        public event Action Healed;
        public event Action Died;

        public float MaxValue { get; private set; }
        public float Value { get; private set; }

        public UnitHealth(float maxHealth)
        {
            SetMaxHealth(maxHealth);
            Value = MaxValue;
        }

        public void Heal(float value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            Value += value;

            if (Value > MaxValue)
                Value = MaxValue;

            Healed?.Invoke();
        }

        public void TakeDamage(float damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            Value -= damage;

            if (Value <= MinValue)
                Die();
        }

        public void SetMaxHealth(float maxHealth)
        {
            if (maxHealth < MinValue)
                throw new ArgumentOutOfRangeException(nameof(maxHealth));

            MaxValue = maxHealth;
        }

        private void Die()
        {
            Died?.Invoke();
        }
    }
}
