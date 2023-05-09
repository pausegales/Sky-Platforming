using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCollision : MonoBehaviour
{
    public static SoundCollision Instance; // 1

    public AudioClip collisionClip; // 2
    
    private Vector3 cameraPosition; // 5

    // Start is called before the first frame update
    void awake()
    {
        Instance = this; // 1
        cameraPosition = Camera.main.transform.position; // 2
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlaySound(AudioClip clip){ // 1
        AudioSource.PlayClipAtPoint(clip, cameraPosition); // 2
    }

    public void PlayShootClip(){
        PlaySound(collisionClip);
    }
}
