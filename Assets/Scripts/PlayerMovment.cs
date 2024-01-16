using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovment : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float _speed = 6.0f;
        private Rigidbody _player;
        
        private void Awake()
        {
            _player = GetComponent<Rigidbody>();
        }
        
        public void MoveCharacter(Vector3 movement)
        {
            _player.AddForce(movement * _speed);       
        }
    }
}

