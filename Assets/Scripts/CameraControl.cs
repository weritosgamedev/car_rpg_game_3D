using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject player;
    private GameObject MainCamera;
    private GameObject LateralCamera;
    private GameObject AirCamera;

    private Vector3 offsetCamera;
    private Vector3 offsetCameraLateral;
    private Vector3 offsetCameraAir;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Car");
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        LateralCamera = GameObject.FindGameObjectWithTag("LateralCamera");
        AirCamera = GameObject.FindGameObjectWithTag("AirCamera");
        offsetCameraLateral = LateralCamera.transform.position - player.transform.position;
        offsetCamera = MainCamera.transform.position - player.transform.position;
        offsetCameraAir = AirCamera.transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
  
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        MainCamera.transform.position = player.transform.position + offsetCamera;
        LateralCamera.transform.position = player.transform.position + offsetCameraLateral;
        AirCamera.transform.position = player.transform.position + offsetCameraAir;
    }
}
