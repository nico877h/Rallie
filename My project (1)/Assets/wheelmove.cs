using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelmove : MonoBehaviour
{
    [SerializeField] WheelCollider frontleft;
    [SerializeField] WheelCollider frontreight;
    [SerializeField] WheelCollider backleft;
    [SerializeField] WheelCollider backreight;

    public float acceleration = 500f;
    public float breakingForce = 300f;

    private float currentAcceleration = 0f;
    private float currentBreakingForce = 0f;

    private void FixedUpdate()
    {
        currentAcceleration = acceleration * Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.Space))
            currentBreakingForce = breakingForce;
        else
            currentBreakingForce = 0f;

        frontleft.motorTorque = currentAcceleration;
        frontreight.motorTorque = currentAcceleration;
        backleft.motorTorque = currentAcceleration;
        backreight.motorTorque = currentAcceleration;

        frontleft.brakeTorque = currentBreakingForce;
        frontreight.brakeTorque = currentBreakingForce;
        backleft.brakeTorque = currentBreakingForce;
        backreight.brakeTorque = currentBreakingForce;
    }
}
