using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //For using scene manager

//This script modifies the camera position to simulate that is falling through
// the clouds behind the player
public class falling_camera : MonoBehaviour
{
    //Reference to the player
    public GameObject player;
    
    //Booleans for comunicating scripts
    //Are public to acces/modify them from other scripts
    public bool falling = false;
    public bool playing = true;
    
    //Audio source reference for falling
    public AudioSource source;
    
    
    // Update is called once per frame
    void Update()
    {
        //Movement of the camera following player + an offset
        if (falling){
            transform.position = new Vector3(0f, player.transform.position.y + 54.0f, 0f);
            
            //Condition to GoTo "EndScene" when the position is too low
            if (transform.position.y < -120.0f){
                SceneManager.LoadScene("EndScene"); //Load scene called Game
            }
        }
        
        //Condition to start playing when set
        if (!playing){
            source.Play();
            playing = true;
        }
    }
}
