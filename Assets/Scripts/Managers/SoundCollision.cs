using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCollision : MonoBehaviour
{
    
    public static SoundCollision Instance;

    //Reference to the audio clip
    public AudioClip collisionClip;
    
    private Vector3 cameraPosition;

    // Start is called before the first frame update
    void awake()
    {
        Instance = this; // 1
        cameraPosition = Camera.main.transform.position; // 2
    }

    private void PlaySound(AudioClip clip){ // 1
        AudioSource.PlayClipAtPoint(clip, cameraPosition); // 2
    }
    
    public void PlayShootClip(){
        PlaySound(collisionClip);
    }
}
