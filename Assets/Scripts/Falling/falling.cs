using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    public GameObject planes_reference;
    public GameObject objects_reference;
    
    public GameObject cameras;
    public GameObject player;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            // Disable the platform
            planes_reference.SetActive(false);
            objects_reference.SetActive(false);
            cameras.GetComponent<falling_camera>().falling = true;
            cameras.GetComponent<falling_camera>().playing = false;

         }
    }
}
