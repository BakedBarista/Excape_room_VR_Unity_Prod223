using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Socket : MonoBehaviour
{
    private IXRSelectInteractable item;
    [SerializeField] private Animator door = null;
    private static int ballsPlaced = 0;

    public void ItemAdded()
    {
        item = GetComponent<XRSocketInteractor>().GetOldestInteractableSelected();
        ballsPlaced++;
        if (ballsPlaced == 2)
        {
            door.Play("DoorOpen");
        }
       
        
         
        
        
    }

    public void ItemRemoved()
    {
        item = null;
        ballsPlaced--;
        
        
    }

}

