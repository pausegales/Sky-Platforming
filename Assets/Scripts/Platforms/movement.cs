using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    //References to the buttons that activates the platform
    public GameObject button1;
    public GameObject button2;
    
    //Booleans for storing if referenced button is pressed
    private bool b1_press;
    private bool b2_press;

    //Platform variables
    public float movementSpeed;
    public int boundaryx_up;
    public int boundaryx_dw;
    public int boundaryy_up;
    public int boundaryy_dw;
    public Space space;
    public Vector3 movementDirection;


    private void Update()
    {
        //Check if there is a button that has activated this platform
        b1_press = button1.GetComponent<pressButton>().active;
        b2_press = button2.GetComponent<pressButton>().active;
        
        //General platform movement
        if (b1_press || b2_press){
            transform.Translate(movementDirection * movementSpeed * Time.deltaTime, space);
            
            //Check if object reached boundaries
            if (transform.position.x >= boundaryx_up || transform.position.x <= boundaryx_dw)
            {
                //Change movement direction
                movementDirection.x = -movementDirection.x;
            }
            
            if (transform.position.z >= boundaryy_up || transform.position.z <= boundaryy_dw)
            {
                //Change movement direction
                movementDirection.z = -movementDirection.z;
            }
        }
    }
}
