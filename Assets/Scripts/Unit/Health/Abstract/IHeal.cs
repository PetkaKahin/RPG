using System;

namespace Unit
{
    public interface IHeal : IHeath
    {
        event Action Healed;

        void Heal(float value);
    }
}
