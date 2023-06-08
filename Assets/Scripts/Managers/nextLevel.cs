using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    
    public GameObject final_button1;
    public GameObject final_button2;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
        }
        
        
        bool b1 = final_button1.GetComponent<pressButton>().isPressed;
        bool b2 = final_button2.GetComponent<pressButton>().isPressed;
        
        if (b1 && b2)
        {
            if (SceneManager.GetActiveScene().buildIndex < 4)
            {
                SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
        
    }
    
    
}
