using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(PlayerMovment))]
    public class InputPlayer : MonoBehaviour
    {
        private Vector3 _movement;
        private PlayerMovment _playerMovment;

        private void Awake()
        {
            _playerMovment = GetComponent<PlayerMovment>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            _movement = new Vector3(-horizontal,0 ,-vertical).normalized;
        }
        
        private void FixedUpdate()
        {
            _playerMovment.MoveCharacter(_movement);
        }
    } 
}

