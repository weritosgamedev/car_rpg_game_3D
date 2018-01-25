using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpin : MonoBehaviour {

    public float maxSpin = 500f;
    private float minSpin = 0f;
    public float spinX;
    public float spinY;
    public float spinZ;



    // Use this for initialization
    void Start () {
        spinX = 0f;
        spinY = 0f;
        spinZ = 0f;
    }
	
	// Update is called once per frame
	void Update () {

        float inputVertical = Input.GetAxis("Vertical");
        print(inputVertical);
        if (inputVertical > 0 && spinX < maxSpin )
        {
            print("Girando hacia adelante...");
            spinX += 1f;
            if (spinX == maxSpin)
            {
                spinX = maxSpin;
            }
            transform.Rotate(spinX, 0, 0);
        }
        if (inputVertical < 0 && spinX > minSpin)
        {
            print("Girando hacia atrás...");
            spinX -= 1;
            transform.Rotate(-spinX, 0, 0);

        }

        

        

	}
}
