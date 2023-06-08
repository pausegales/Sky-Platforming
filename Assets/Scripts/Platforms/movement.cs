using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    private bool b1_press;
    private bool b2_press;

    
    public float movementSpeed;
    public int boundaryx_up;
    public int boundaryx_dw;
    public int boundaryy_up;
    public int boundaryy_dw;
    public Space space;

    public Vector3 movementDirection;

    private void Start()
    {
        print(SceneManager.sceneCount);
        
    }

    private void Update()
    {
        b1_press = button1.GetComponent<pressButton>().active;
        b2_press = button2.GetComponent<pressButton>().active;
        
        if (b1_press || b2_press){
            transform.Translate(movementDirection * movementSpeed * Time.deltaTime, space);
            
            // Check if object reached boundaries
            if (transform.position.x >= boundaryx_up || transform.position.x <= boundaryx_dw)
            {
                // Change movement direction
                movementDirection.x = -movementDirection.x;
            }
            
            if (transform.position.z >= boundaryy_up || transform.position.z <= boundaryy_dw)
            {
                // Change movement direction
                movementDirection.z = -movementDirection.z;
            }
            
        }
    }
}
