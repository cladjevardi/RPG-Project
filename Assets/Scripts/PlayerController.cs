using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

    public LayerMask movementMask;

    Camera cam; // Reference to the camera
    PlayerMotor motor;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)) // If the LEFT mouse button is pressed
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); // Cast out a ray from the camera to whatever is clicked
            RaycastHit hit; // What the ray has hit

            if(Physics.Raycast(ray, out hit, 100, movementMask)) // If the ray hits sometimes within range of 100
            {
                Debug.Log("We hit " + hit.collider.name + " " + hit.point); // Debug to see if its working
                motor.MoveToPoint(hit.point); // Move our player to what we hit

                // Stop focusing any objects
            }
        }
        if (Input.GetMouseButtonDown(1)) // If the RIGHT mouse button is pressed
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); // Cast out a ray from the camera to whatever is clicked
            RaycastHit hit; // What the ray has hit
            if (Physics.Raycast(ray, out hit, 100)) // If the ray hits sometimes within range of 100
            {
                // Check if we hit an interactable
                // If we did set it as our focus
            }
        }
    }
}
