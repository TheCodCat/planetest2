using UnityEngine;
using UnityEngine.Events;

public class PlaneTestController : MonoBehaviour
{
    [SerializeField] private UnityEvent OnCollision;
    private void OnCollisionEnter(Collision collision)
    {
        var fly = collision.rigidbody;
        fly.isKinematic = true;
        OnCollision?.Invoke();
    }
}
