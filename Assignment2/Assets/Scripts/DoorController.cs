using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = 90f; // Angle to open the door
    public float openSpeed = 2f; // Speed at which the door opens

    private bool isOpen = false; // Flag to track if the door is open
    private Quaternion closedRotation; // Initial rotation of the door when closed
    private Quaternion openRotation; // Target rotation of the door when open

    void Start()
    {
        // Store the initial rotation of the door
        closedRotation = transform.rotation;

        // Calculate the target rotation when the door is open
        openRotation = Quaternion.Euler(0, openAngle, 0) * closedRotation;
    }

    void Update()
    {
        // Check if the door is open and rotate towards the open rotation
        if (isOpen)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, openRotation, openSpeed * Time.deltaTime);
        }
    }

    public void OpenDoor()
    {
        // Set the flag to indicate that the door is open
        isOpen = true;
    }
}
