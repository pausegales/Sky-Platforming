using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //So you can use SceneManager

//This script manages the pressing of any of the buttons for the scenes
public class pressRestart : MonoBehaviour
{
    //Variable to set in the editor to which scene we want to jump
    public int rst_ext_str;
    
    //Boolean variables for managing 2 players in the same button
    private bool p1;
    private bool p2;


    void Update()
    {
        //Conditions for changing the scene, restarting or quit the game
        if (p1 && p2 && (rst_ext_str == 1)){
            //Load scene Level1
            SceneManager.LoadScene("Level1");
        }
        if (p1 && p2 && (rst_ext_str == 2)){
            //Quit Game
            Application.Quit();
        }
        if (p1 && p2 && (rst_ext_str == 3)){
            //Restart game
            SceneManager.LoadScene("IntroScene");
        }
    }

    //Collision triggers of the button/platform
    private void OnTriggerEnter (Collider other){
        //Conditions for managing both pressing button/platform
        if (other.CompareTag("Player1")){
            p1 = true;
        }
        if (other.CompareTag("Player2")){
           p2 = true;
        }
    }
    
    //Exit trigger colliders
    private void OnTriggerExit (Collider other){
        if (other.CompareTag("Player1")){
            p1 = false;
        }
        if (other.CompareTag("Player2")){
           p2 = false;
        }
    }
}
