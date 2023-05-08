using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axle : MonoBehaviour
{
    [SerializeField] private WheelCollider[] _wheels;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpeedUp(float speed)
    {
        _wheels[0].motorTorque = speed;
        _wheels[1].motorTorque = speed;
    }

    public void Brake(float speed)
    {
        _wheels[0].brakeTorque = speed;
        _wheels[1].brakeTorque = speed;
    }

    public void Turn(float axis)
    {
        _wheels[0].steerAngle = axis * 45;
        _wheels[1].steerAngle = axis * 45;
    }


}
