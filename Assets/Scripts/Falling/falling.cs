using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    //Reference tp to the Empty that contains all the platforms/objects
    public GameObject planes_reference;
    public GameObject objects_reference;
    
    //Reference to the camera and player for setting parameters if condition
    public GameObject cameras;
    public GameObject player;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        //Check if one or both players falls from the platforms
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            // Disable the platform
            planes_reference.SetActive(false);
            objects_reference.SetActive(false);
            
            //Enable parameters in other scripts to fall
            cameras.GetComponent<falling_camera>().falling = true;
            cameras.GetComponent<falling_camera>().playing = false;

         }
    }
}
