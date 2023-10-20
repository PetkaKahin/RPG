using UnityEngine;
using Zenject;
using System;

namespace Unit
{ 
    public class PlayerUnit : MonoBehaviour, IMovable
    {
        [Header("Options")]
        [SerializeField] private float _speed;
        [SerializeField] private float _maxHealth;

        private UnitStateMachine _stateMachine;

        public UnitHealth Health;

        public float Speed => _speed;
        public float MaxHealth => _maxHealth;
        public Transform Transform => transform;

        [Inject]
        private void Construct(UnitStateMachine stateMachine, UnitHealth health)
        {
            _stateMachine = stateMachine;
            Health = health;
        }

        private void OnValidate()
        {
            SetSpeed(_speed);

            Health?.SetMaxHealth(_maxHealth);
        }

        private void Update()
        {
            _stateMachine.Update();
        }

        public void SetSpeed(float speed) 
        {
            if (speed < 0)
                throw new ArgumentOutOfRangeException(nameof(speed));

            _speed = speed;
        }
    }
}