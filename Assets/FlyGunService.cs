using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class FlyGunService : MonoBehaviour
{
    [SerializeField] private InputActionProperty flugun;
    [SerializeField] private UnityEvent<double> UnityEvent;
    [SerializeField] private UnityEvent<bool> UnityEventIsPush;
    [SerializeField] private float maxTime;
    [SerializeField] private bool point;

    [SerializeField] private UnityEvent<float> UnityEventAngle;
    [SerializeField] private float currentAngle;
    public float CurrentAngle
    {
        get => currentAngle;
        set
        {
            currentAngle = value;
            UnityEventAngle?.Invoke(value);
        }
    }
    private void OnEnable()
    {
        flugun.action.Enable();

        flugun.action.canceled += Action_performed;
    }

    private void Action_performed(InputAction.CallbackContext obj)
    {
        var result = obj.time - obj.startTime;

        result = result > maxTime ? 1 : result / maxTime;

        UnityEvent?.Invoke(result);
    }

    private void OnDisable()
    {
        flugun.action.Disable();

        flugun.action.canceled -= Action_performed;
    }
    public void ChangeAngle(float value)
    {
        CurrentAngle = value;
    }
}
