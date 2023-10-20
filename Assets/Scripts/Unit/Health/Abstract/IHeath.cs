namespace Unit
{
    public interface IHeath
    {
        const float MinHealth = 0;

        float Health { get; }
        float MaxHealth { get; }

        void SetMaxHealth(float maxHealth);
    }
}
