using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages everithing that involves players pressing buttons (Apart from "JumpingScene buttons)
public class pressButton : MonoBehaviour
{
    //Platform stuff
    public GameObject platformToActivate;
    public int speed;
    
    //Button state and stuff
    public bool isPressed = false;
    private Vector3 pressed;
    private Vector3 unpressed;
    
    //Player stuff and manager for 2 players in the same button
    public int player_selected;
    private bool both_press;
    private bool p1;
    private bool p2;
    //Variables to generailze code for different buttons and players
    private string player1;
    private string player2;
    
    public bool active = false;
    
    //Audio source for pressing effect
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        //Init the button possitions for pressed and unpressed
        pressed = new Vector3(0.0f, -0.28f, 0.0f);
        unpressed = new Vector3(0.0f, 0.0f, 0.0f);
        
        //Set the variables to the correct player for further use
        if (player_selected == 1){
            player1 =  "Player1";
            player2 =  "Player1";
        }
        if (player_selected == 2){
            player1 =  "Player2";
            player2 =  "Player2";
        }
        if (player_selected == 0){
            player1 =  "Player1";
            player2 =  "Player2";
            both_press = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Conditions when the button is set for 1 player
        if (!both_press){
            if(isPressed){
                transform.localPosition = pressed;
                active = true;
                source.Play();
            }
            else{
                transform.localPosition = unpressed;
                active = false;
            };
        }
        
        //Conditions when the button is set for 2 player
        if (both_press){
            if(isPressed && p1 && p2){
                transform.localPosition = pressed;
                active = true;
                source.Play();
            }
            else{
                transform.localPosition = unpressed;
                active = false;
            };
        }
    }

    //Collider
    private void OnTriggerEnter (Collider other){
        if ( (other.CompareTag(player1) || other.CompareTag(player2)) && !isPressed){
            isPressed = true;
        }
        //Conditions to later check if 2 players are pressing
        if (other.CompareTag("Player1")){
            p1 = true;
        }
        if (other.CompareTag("Player2")){
            p2 = true;
        }
    }
    
    //Exit collider
    private void OnTriggerExit (Collider other){
        if ( (other.CompareTag(player1) || other.CompareTag(player2)) && isPressed){
            isPressed = false;
        }
        
        //Conditions to later check if 2 players are pressing
        if (other.CompareTag("Player1")){
            p1 = false;
        }
        if (other.CompareTag("Player2")){
            p2 = false;
        }
    }
}
