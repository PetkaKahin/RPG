using UnityEngine;
using Zenject;
using Items;
using System;

namespace Unit
{ 
    public class PlayerUnit : MonoBehaviour, IMovable
    {
        [SerializeField] private PlayerConfig _config;
        [SerializeField] private Sword _sword;

        private UnitStateMachine _stateMachine;
        public IItem Item;

        public UnitHealth Health;

        public float Speed => _config.Speed;
        public float MaxHealth => _config.Health;
        public Transform Transform => transform;

        [Inject]
        private void Construct(UnitStateMachine stateMachine, UnitHealth health)
        {
            _stateMachine = stateMachine;
            Health = health;
            Item = _sword;
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

        public void SetItem(IItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            Item = item;
        }
    }
}