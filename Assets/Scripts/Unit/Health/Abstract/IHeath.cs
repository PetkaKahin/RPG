namespace Unit
{
    public interface IHeath
    {
        const float MinValue = 0;

        float Value { get; }
        float MaxValue { get; }

        void SetMaxHealth(float maxHealth);
    }
}
