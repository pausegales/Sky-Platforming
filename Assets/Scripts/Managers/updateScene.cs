using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class updateScene : MonoBehaviour
{
    public int scene;

    void Update(){
        if (Input.anyKeyDown)
        {
            switch(scene) {
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
                scene++;
                scene = scene%5;
        }
    }
}