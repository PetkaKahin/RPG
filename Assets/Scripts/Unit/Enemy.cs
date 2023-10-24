using UnityEngine;

namespace Unit
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class Enemy : MonoBehaviour
    {
        public UnitHealth Health = new UnitHealth(15);

        public Enemy()
        {
            Health.Died += Die;
        }

        private void Die()
        {
            gameObject.SetActive(false);
        }
    }
}
