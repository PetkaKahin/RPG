using System;

namespace Weapon
{
    public interface IDamager
    {
        float Damage { get; }

        event Action AttackCompleted;

        void SetDamage(float damage);
        void Attack();
    }
}
