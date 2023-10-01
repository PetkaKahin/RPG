using UnityEngine;
using Zenject;

namespace Unit
{
    public class PlayerUnit : MonoBehaviour
    {
        [SerializeField] private float _speed;

        public IMover Mover {  get; private set; }

        [Inject]
        private void Construct(IMover mover)
        {
            Mover = mover;
            Mover.SetSpeed(_speed);
        }

        private void Update()
        {
            Mover.Move();
        }
    }
}