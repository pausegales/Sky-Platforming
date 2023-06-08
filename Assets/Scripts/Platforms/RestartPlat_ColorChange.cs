using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPlat_ColorChange : MonoBehaviour
{
    Renderer rend;
    
    private bool one_press;
    private bool two_pressed;
    
    public int counter;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 1){
            rend.material.color = Color.red;
        }
        if (counter == 0){
            rend.material.color = Color.blue;
        }
    }
    
    
    
    private void OnTriggerEnter (Collider other){
        if (other.CompareTag("Player1")){
            counter++;
        }
        if (other.CompareTag("Player2")){
            counter++;
        }
    }
    
    private void OnTriggerExit (Collider other){
        if (other.CompareTag("Player1")){
            counter--;
        }
        if (other.CompareTag("Player2")){
            counter--;
        }
    }
    
}
