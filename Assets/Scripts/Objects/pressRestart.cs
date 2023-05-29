using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //So you can use SceneManager


public class pressRestart : MonoBehaviour
{
    //private bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter (Collider other){
        if ( (other.CompareTag("Player1") || other.CompareTag("Player2"))){
            SceneManager.LoadScene("Level1"); //Load scene called Game
        }
    }
}
