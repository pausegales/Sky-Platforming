using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressButton : MonoBehaviour
{
    public GameObject platformToActivate;
    public int speed;
    public Space space;
    private bool isPressed = false;
    
    private Vector3 pressed;
    private Vector3 unpressed;
    

    // Start is called before the first frame update
    void Start()
    {
        pressed = new Vector3(0.0f, -0.28f, 0.0f);
        unpressed = new Vector3(0.0f, 0.0f, 0.0f);
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
        if (other.CompareTag("Player") && !isPressed){
            isPressed = true;
        }
    }
    
    private void OnTriggerExit (Collider other){
        if (other.CompareTag("Player") && isPressed){
            isPressed = false;
        }
        
    }
        
    


}
