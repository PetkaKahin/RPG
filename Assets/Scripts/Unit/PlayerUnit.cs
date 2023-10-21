using UnityEngine;
using Zenject;

namespace Unit
{ 
    public class PlayerUnit : MonoBehaviour, IMovable
    {
        [SerializeField] private PlayerConfig _config;

        private UnitStateMachine _stateMachine;

        public UnitHealth Health;

        public float Speed => _config.Speed;
        public float MaxHealth => _config.Health;
        public Transform Transform => transform;

        [Inject]
        private void Construct(UnitStateMachine stateMachine, UnitHealth health)
        {
            _stateMachine = stateMachine;
            Health = health;
        }

        private void OnValidate()
        {
            SetSpeed(Speed);

            Health?.SetMaxHealth(MaxHealth);
        }

        private void Update()
        {
            _stateMachine.Update();
        }

        public void SetSpeed(float speed) => _config.SetSpeed(speed);
    }
}