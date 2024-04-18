using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Socket : MonoBehaviour
{
    private IXRSelectInteractable item;
    public string acceptedTag; // Specify the accepted tag for this socket
    public GameObject itemToActivate; // Reference to the item to activate when correct balls are placed
    private bool ballPlaced = false; // Flag to track if correct ball is placed

    public void ItemAdded()
    {
        item = GetComponent<XRSocketInteractor>().GetOldestInteractableSelected();

        if (item != null)
        {
            // Check if the added item is a ball with the correct tag
            if (item.CompareTag(acceptedTag))
            {
                Debug.Log("Correct ball placed at the socket.");
                // Set flag to true indicating correct ball is placed
                ballPlaced = true;
                CheckBallsPlaced(); // Check if both balls are placed
            }
            else
            {
                Debug.Log("Incorrect ball placed at the socket.");
                // Do something when incorrect ball is added (optional)
            }
        }
    }

    public void ItemRemoved()
    {
        item = null;
        // Reset flag to false indicating no correct ball is placed
        ballPlaced = false;
        
    }

    private void CheckBallsPlaced()
    {
        // Get the other socket
        Socket[] sockets = FindObjectsOfType<Socket>();
        foreach (Socket socket in sockets)
        {
            if (socket != this && socket.ballPlaced)
            {
                // If both sockets have correct balls placed, activate the item
                Debug.Log("Both sockets have correct balls placed.");
                itemToActivate.SetActive(true);
                return;
            }
        }
    }
}

