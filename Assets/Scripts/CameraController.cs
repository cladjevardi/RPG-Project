using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target; // Target to follow

    public Vector3 offset; // The camera's offset from the target
    public float zoomSpeed = 4f; // Speed of zoom
    public float minZoom = 5f; // Minimum zoom distance
    public float maxZoom = 15f; // Maximum zoom distance

    public float pitch = 2f; // Shifts the camera up from our character's feet

    public float yawSpeed = 100f; // Used to rotate the camera

    private float currentZoom = 10f; // Our current zoom
    public float currentYaw = 0f; // Current rotation of the camera

    private void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed; // Zoom is bound to mouse scroll wheel
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom); // Keeps zoom between min and max

        currentYaw += Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime; // Gets the values for rotating the camera
    }

    void LateUpdate() // Same as update but called right after update
    {
        transform.position = target.position - offset * currentZoom; // Move the camera
        transform.LookAt(target.position + Vector3.up * pitch); // Look at our target        

        transform.RotateAround(target.position, Vector3.up, currentYaw); // Rotate the camera
    }
}
