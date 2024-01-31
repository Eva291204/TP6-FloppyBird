using UnityEngine;

public class BirdMove : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _forceUp;
    [SerializeField] private float _speedRotation;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (GameManager.Instance.GameIsStart)
        {
            _rb.useGravity = true;
            transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _speedRotation); //rotation de l'oisseau

            if (Input.GetKey(KeyCode.Space))
            {
                _rb.velocity = Vector3.up * _forceUp;
            }
        }
    }
}
