using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    //Reference to the buttons that states the end of the level
    public GameObject final_button1;
    public GameObject final_button2;
    
    
    // Update is called once per frame
    void Update()
    {
        
        
        //Get if the referenced buttons are pressed or not
        bool b1 = final_button1.GetComponent<pressButton>().isPressed;
        bool b2 = final_button2.GetComponent<pressButton>().isPressed;
        
        //If both pressed, jump to following level
        if (b1 && b2)
        {
            if (SceneManager.GetActiveScene().buildIndex < 4)
            {
                //The scene indexes are set in the build settings
                //Intro     --> idx 0
                //Level1    --> idx 1
                //Level2    --> idx 2
                //Level3    --> idx 3
                //EndScene  --> idx 4

                SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
