namespace Unit
{
    public interface IMover
    {
        float Speed { get; }

        void SetSpeed(float value);
        void Move();
    }
}