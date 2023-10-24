namespace Weapon
{
    public interface IDamager
    {
        float Damage { get; }

        void SetDamage(float damage);
        void Attack();
    }
}
