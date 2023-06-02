using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressButton : MonoBehaviour
{
    public GameObject platformToActivate;
    public int speed;
    public int player_selected;
    public bool both_press;
    public AudioSource source;
        
    private string player1;
    private string player2;
    private bool isPressed = false;
    private Vector3 pressed;
    private Vector3 unpressed;
    

    // Start is called before the first frame update
    void Start()
    {
        pressed = new Vector3(0.0f, -0.28f, 0.0f);
        unpressed = new Vector3(0.0f, 0.0f, 0.0f);
        
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
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPressed){
            transform.localPosition = pressed;
            platformToActivate.GetComponent<movement>().movementSpeed = speed;
        }
        else{
            transform.localPosition = unpressed;
            platformToActivate.GetComponent<movement>().movementSpeed = 0;
        };
    }

    private void OnTriggerEnter (Collider other){
        if ( (other.CompareTag(player1) || other.CompareTag(player2)) && !isPressed){
            isPressed = true;
            source.Play();
        }
    }
    
    private void OnTriggerExit (Collider other){
        if ( (other.CompareTag(player1) || other.CompareTag(player2)) && isPressed){
            isPressed = false;
        }
    }
}
