using UnityEngine;
using Zenject;
using System;

namespace Unit
{
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(Rigidbody2D))]

    public class PlayerUnit : MonoBehaviour, IMovable
    {
        [SerializeField] private float _speed;

        private UnitStateMachine _stateMachine;

        private BoxCollider2D _collider;
        private Rigidbody2D _rigidbody;

        public float Speed => _speed;

        [Inject]
        private void Construct(UnitStateMachine stateMachine)
        {
            _collider = GetComponent<BoxCollider2D>();
            _rigidbody = GetComponent<Rigidbody2D>();

            _stateMachine = stateMachine;
        }

        private void OnValidate()
        {
            SetSpeed(_speed);
        }

        private void Update()
        {
            _stateMachine.Update();
        }

        public Rigidbody2D GetRigidbody() => _rigidbody;

        public Transform GetTransform() => transform;

        public void SetSpeed(float speed)
        {
            if (speed < 0)
                throw new ArgumentOutOfRangeException(nameof(speed));

            _speed = speed;
        }
    }
}