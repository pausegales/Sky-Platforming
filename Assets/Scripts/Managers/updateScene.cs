using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class updateScene : MonoBehaviour
{

    void Update(){
        if (Input.anyKeyDown)
        {
            gameSettings.current_scene = gameSettings.current_scene + 1;
            gameSettings.current_scene = gameSettings.current_scene%6;
            
            switch(gameSettings.current_scene) {
                case 0:
                    SceneManager.LoadScene("Level1"); 
                    break;
                case 1:
                    SceneManager.LoadScene("Level2"); 
                    break;
                case 2:
                    SceneManager.LoadScene("Level3"); 
                    break;
                case 3:
                    SceneManager.LoadScene("Level4"); 
                    break;
                case 4:
                    SceneManager.LoadScene("Level5"); 
                    break;
                case 5:
                    SceneManager.LoadScene("Scene"); 
                    break;
                }
        }
    }
}
