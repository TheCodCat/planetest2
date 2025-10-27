using UnityEngine;

[RequireComponent(typeof(Rigidbody))]   
public class Flight : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _airfriction;
    [SerializeField] private float _maxRotationA;
    [SerializeField] private float _minRotationA;
    [SerializeField] private float _startingSpeed;
    [Space]
    [SerializeField] private float _maxForce;
    [SerializeField] private bool point;
    //[SerializeField] private Transform centerOfMass;


    private Vector3 _startPosition;
    private Rigidbody _rigidbody;
    private Quaternion _maxRotation;
    private Quaternion _minRotation;

    void Start()
    {
        _startPosition = transform.position;
        _rigidbody = GetComponent<Rigidbody>();
        
        _maxRotation = Quaternion.Euler(0,0,_maxRotationA);
        _minRotation = Quaternion.Euler(0, 0, _minRotationA);

        //_rigidbody.centerOfMass = centerOfMass.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    _rigidbody.velocity = new Vector3(_speed, _startingSpeed);
        //    transform.rotation = _maxRotation;
        //}
        // ransform.rotation = Quaternion.Lerp(transform.rotation, _minRotation)
    }

    public void FlyGunind(double value)
    {
        if (point)
        {
            _rigidbody.isKinematic = false;
            _rigidbody.isKinematic = false;
            _rigidbody.isKinematic = false;
            Debug.Log(value);
            _rigidbody.AddForce(transform.forward  * ((float)value * _maxForce));
            point = false;
        }
    }

    public void ChangeAngle(float value)
    {
        transform.localRotation = Quaternion.Euler(value,0,0);
    }

    public void ChangePoint(bool value)
    {
        point = value;
    }
}
