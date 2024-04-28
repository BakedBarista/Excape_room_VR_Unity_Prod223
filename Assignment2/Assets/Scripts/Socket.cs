using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Socket : MonoBehaviour
{
    private XRSocketInteractor socket;
    [SerializeField] private Animator door = null;
    private static bool greenPlaced = false;
    private static bool redPlaced = false;

    private void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    public void GreenSocketCheck()
    {
        GameObject item = socket.selectTarget.gameObject;
        if (item.CompareTag("GreenBall"))
        {
            greenPlaced = true;
        } else
        {
            greenPlaced = false;
        }
        if (greenPlaced && redPlaced)
        {
            door.Play("DoorOpen");
        }
    }

    public void RedSocketCheck()
    {
        GameObject item = socket.selectTarget.gameObject;
        if (item.CompareTag("RedBall"))
        {
            redPlaced = true;
        }
        else
        {
            redPlaced = false;
        }
        if (greenPlaced && redPlaced)
        {
            door.Play("DoorOpen");
        }
    }



}

