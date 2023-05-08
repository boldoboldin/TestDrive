using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCtrl : MonoBehaviour
{
    public float speed;
    
    [SerializeField] private Axle _axle;
    [SerializeField] Vector3 centerMass;

    private Rigidbody _rb;

   
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        _rb.centerOfMass = centerMass;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float _vAxis = Input.GetAxis("Vertical");
        float _hAxis = Input.GetAxis("Horizontal");

        if (Mathf.Abs (_vAxis) >= 0)
        {
            _axle.SpeedUp(speed * _vAxis);
        }

        if(Mathf.Abs(_hAxis) >= 0)
        {
            _axle.Turn(_hAxis);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            _axle.Brake(speed);
        }
        else
        {
            _axle.Brake(0);
        }
    }
}
