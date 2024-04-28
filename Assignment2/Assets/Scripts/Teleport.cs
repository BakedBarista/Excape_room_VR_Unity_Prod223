using UnityEngine;
using UnityEngine.XR;

public class teleportPlayer : MonoBehaviour
{
    public GameObject player;
    public void teleport()
    {
        // Set the position of the XR rig to the desired coordinates
        
        player.transform.position = new Vector3(3.64f, -0.207f, 0.3f);
        player.transform.Rotate(Vector3.up, 90f);
    }
}