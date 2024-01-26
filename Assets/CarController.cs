using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 20f;
    private Rigidbody _rigidBody;
    private float _horizontal;
    private float _vertical;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        _rigidBody.AddForce(transform.forward * _vertical * (Time.fixedDeltaTime * speed), ForceMode.VelocityChange);
        _rigidBody.AddTorque(new Vector3(0, _horizontal, 0) *(Time.fixedDeltaTime * rotationSpeed), ForceMode.VelocityChange);
    }
}
