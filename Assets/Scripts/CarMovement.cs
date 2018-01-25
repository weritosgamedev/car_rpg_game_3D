using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed;
    private float maxMotorTorque = 10f;
    private float maxSpeed = 10f;
    private float brake = 1.5f;
    private float n2o = 100f;

    private GameObject[] wheels;
    private WheelCollider frontRight;
    private WheelCollider frontLeft;
    private WheelCollider backRight;
    private WheelCollider backLeft;

    private Vector3 input = new Vector3();

    


    // Use this for initialization
    void Start()
    {
        wheels = GameObject.FindGameObjectsWithTag("wheel");
        frontRight = wheels[0].GetComponent<WheelCollider>();
        frontLeft = wheels[1].GetComponent<WheelCollider>();
        backRight = wheels[2].GetComponent<WheelCollider>();
        backLeft = wheels[3].GetComponent<WheelCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        input.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis("MovementFwBw"));
        if (frontRight.motorTorque < maxMotorTorque && frontLeft.motorTorque < maxMotorTorque && backRight.motorTorque < maxMotorTorque && backLeft.motorTorque < maxMotorTorque)
        {
            print("Torque menor");
            frontRight.motorTorque += 0.5f;
            frontLeft.motorTorque += 0.5f;
            backRight.motorTorque += 0.5f;
            backLeft.motorTorque += 0.5f;
        }
        /*
        if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
        {
            GetComponent<Rigidbody>().drag = 0;
            GetComponent<Rigidbody>().AddForce(input * moveSpeed);
        }
        if (GetComponent<Rigidbody>().velocity.magnitude > maxSpeed)
        {
            GetComponent<Rigidbody>().drag = 0.5f;
        }
        if (Input.GetKey(KeyCode.Space) == true)
        {
            print("Presione Space");
            if (GetComponent<Rigidbody>().velocity.magnitude > 0)
            {
                print("Quiero frenar");
                GetComponent<Rigidbody>().drag = brake;
            }
        }
        if (Input.GetKey(KeyCode.T) == true)
        {
            print("Brrrrm ");
            if (n2o > 0f)
            {
                GetComponent<Rigidbody>().drag = 0;
                GetComponent<Rigidbody>().AddForce(input * moveSpeed * 5);
                n2o -= 1f;
            }   
        }
        if (Input.GetKey(KeyCode.R) == true)
        {
            print("glu glu glu...");
            n2o = 100f;
        }
        */
    }

    
}
