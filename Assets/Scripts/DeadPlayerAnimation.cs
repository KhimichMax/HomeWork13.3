using UnityEngine;

public class DeadPlayerAnimation : MonoBehaviour
{
    [SerializeField] Animation _anim;
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private GameObject _playerObj;
    private void TriggerParticleSystem()
    {
        _particleSystem.Play();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _anim.Play();
            Invoke("TriggerParticleSystem", 0.3f);
        }
    }
}
