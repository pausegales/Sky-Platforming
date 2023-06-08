using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPlat_ColorChange : MonoBehaviour
{
    //Variable for changing the material on the script
    [SerializeField] public Material myMaterial;
    
    //Booleans for detecting collisions with the text
    private bool one_press;
    private bool two_pressed;
    
    //Counter to know how may players are touching the text
    public int counter;
    
    //Color initialization for further use in update
    Color customColor = new Color(0.33f, 0.17f, 0.81f, 1.0f);
    

    // Update is called once per frame
    void Update()
    {
        //Sets one color depending on the numer of players touching the text
        if (counter == 1){
            //rend.material.color = Color.red;
            myMaterial.color = Color.green;
            
        }
        if (counter == 0){
            //rend.material.color = Color.blue;
            myMaterial.color = customColor;
        }
    }
    

    //Colliders
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
