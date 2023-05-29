using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //So you can use SceneManager


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
            if (transform.position.y < -140.0f){
                SceneManager.LoadScene("EndScene"); //Load scene called Game
                
            }
        }
        if (!playing){
            source.Play();
            playing = true;
        }
        
    }
}
