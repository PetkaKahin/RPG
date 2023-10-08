using UnityEngine;
using Zenject;

namespace Unit
{
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(Rigidbody2D))]

    public class PlayerUnit : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private IMover _mover;

        private BoxCollider2D _collider;
        private Rigidbody2D _rigidbody;

        public float Speed => _mover.Speed;

        [Inject]
        private void Construct(IMover mover)
        {
            _mover = mover;

            _collider = GetComponent<BoxCollider2D>();
            _rigidbody = GetComponent<Rigidbody2D>();

            _mover.BindTo(_rigidbody);
            _mover.BindTo(transform);
            _mover.SetSpeed(_speed);
        }

        private void OnValidate()
        {
            _mover?.SetSpeed(_speed);
        }

        private void Update()
        {
            _mover.Move();
        }
    }
}