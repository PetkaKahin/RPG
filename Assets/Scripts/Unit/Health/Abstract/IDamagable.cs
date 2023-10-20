using System;

namespace Unit
{
    public interface IDamagable : IHeath
    {
        event Action Died;

        void TakeDamage(float damage);
    }
}
