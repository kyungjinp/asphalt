using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1 : MonoBehaviour
{
    public float carSpeed = 10f;
    public Transform[] targets;
    private Rigidbody _rigidbody;

    private int _currentTargetIndex = 0;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        var pos = targets[_currentTargetIndex].position;
        var dir = pos - transform.position;
        var normalizedDir = new Vector3(dir.x, 0, dir.z).normalized;

        _rigidbody.velocity = normalizedDir * carSpeed;

        transform.LookAt(pos);

        if(Vector3.Distance(pos, transform.position) < 5f){
            _currentTargetIndex ++;
        }
    }
}
