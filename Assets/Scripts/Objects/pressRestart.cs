using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //So you can use SceneManager


public class pressRestart : MonoBehaviour
{
    public int rst_ext_str;
    
    private bool p1;
    private bool p2;
    //private bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
    }
    
    void Update()
    {
        if (p1 && p2 && (rst_ext_str == 1)){
            SceneManager.LoadScene("Level1"); //Load scene called Game
        }
        if (p1 && p2 && (rst_ext_str == 2)){
            Application.Quit(); //Quit Game
        }
        if (p1 && p2 && (rst_ext_str == 3)){
            SceneManager.LoadScene("Level1"); //Quit Game
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
