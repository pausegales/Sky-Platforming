using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressButton : MonoBehaviour
{
    public GameObject topButton;
    public Space space;
    private bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter (Collider other){
        if (other.CompareTag("Player") && !isPressed){
            transform.Translate((float)0, (float)0, (float)-0.28, space);
            isPressed = true;
        }
        
    }


}
