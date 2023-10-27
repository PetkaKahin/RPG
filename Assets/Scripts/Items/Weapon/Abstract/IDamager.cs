using System;

namespace Items
{
    public interface IDamager : IItem
    {
        float Damage { get; }

        event Action AttackCompleted;

        void SetDamage(float damage);
        void Attack();
    }
}
