using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_camera : MonoBehaviour
{
    
    public GameObject player;
    
    public bool falling = false;
    public bool playing = true;
    
    public AudioSource source;
    
    
    // Update is called once per frame
    void Update()
    {
        if (falling){
            transform.position = new Vector3(0f, player.transform.position.y + 54.0f, 0f);
        }
        if (!playing){
            source.Play();
            playing = true;
        }
        
    }
}
