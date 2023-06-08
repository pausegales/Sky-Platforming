using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //So you can use SceneManager


public class pressRestart : MonoBehaviour
{
    public bool restart_or_exit;
    
    private bool p1;
    private bool p2;
    //private bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
    }
    
    void Update()
    {
        if (p1 && p2 && restart_or_exit){
            SceneManager.LoadScene("Level1"); //Load scene called Game
        }
        if (p1 && p2 && !restart_or_exit){
            Application.Quit(); //Quit Game
        }
        
    }

    private void OnTriggerEnter (Collider other){
        if (other.CompareTag("Player1")){
            p1 = true;
        }
        if (other.CompareTag("Player2")){
           p2 = true;
        }
    }
    
    private void OnTriggerExit (Collider other){
        if (other.CompareTag("Player1")){
            p1 = false;
        }
        if (other.CompareTag("Player2")){
           p2 = false;
        }
    }
}
