using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    //References to the buttons that activates the platform
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    
    
    //Booleans for storing if referenced button is pressed
    private bool b1_press;
    private bool b2_press;
    private bool b3_press;

    //Platform variables
    public float movementSpeed;
    public int boundaryx_up;
    public int boundaryx_dw;
    public int boundaryy_up;
    public int boundaryy_dw;
    public Space space;
    public Vector3 movementDirection;
    public bool independent_move;


    private void Update()
    {
        //Check if there is a button that has activated this platform
        b1_press = button1.GetComponent<pressButton>().active;
        b2_press = button2.GetComponent<pressButton>().active;
        b3_press = button3.GetComponent<pressButton>().active;
        
        //Independent movement from buttons
        if (independent_move){
            transform.Translate(movementDirection * movementSpeed * Time.deltaTime, space);
            
            //Check if object reached boundaries
            if (transform.position.x >= boundaryx_up || transform.position.x <= boundaryx_dw)
            {
//                Vector3 pos = new Vector3(0,transform.position.y,transform.position.z);
//                if ( transform.position.x >= boundaryx_up ) {
//                    pos.x = boundaryx_up - 2;
//                    transform.position = pos;
//                }
//                if ( transform.position.x <= boundaryx_dw ) {
//                    pos.x = boundaryx_dw + 2;
//                    transform.position = pos;
//                }
                //Change movement direction
                movementDirection.x = -movementDirection.x;
            }
            
            if (transform.position.z >= boundaryy_up || transform.position.z <= boundaryy_dw)
            {
//                Vector3 pos = new Vector3(transform.position.x, transform.position.y,0);
//                if ( transform.position.z >= boundaryy_up ) {
//                    pos.z = boundaryy_up - 2;
//                    transform.position = pos;
//                }
//                if ( transform.position.z <= boundaryy_dw ) {
//                    pos.z = boundaryy_dw + 2;
//                    transform.position = pos;
//                }
                //Change movement direction
                movementDirection.z = -movementDirection.z;
            }
        }
        
        //General platform movement
        if ((b1_press || b2_press || b3_press) && !independent_move) {
            transform.Translate(movementDirection * movementSpeed * Time.deltaTime, space);
            
            //Check if object reached boundaries
            if (transform.position.x >= boundaryx_up || transform.position.x <= boundaryx_dw)
            {
//                Vector3 pos = new Vector3(0,transform.position.y,transform.position.z);
//                if ( transform.position.x >= boundaryx_up ) {
//                    pos.x = boundaryx_up - 2;
//                    transform.position = pos;
//                }
//                if ( transform.position.x <= boundaryx_dw ) {
//                    pos.x = boundaryx_dw + 2;
//                    transform.position = pos;
//                }
                //Change movement direction
                movementDirection.x = -movementDirection.x;
            }
            
            if (transform.position.z >= boundaryy_up || transform.position.z <= boundaryy_dw)
            {
//                Vector3 pos = new Vector3(transform.position.x, transform.position.y,0);
//                if ( transform.position.z >= boundaryy_up ) {
//                    pos.z = boundaryy_up - 2;
//                    transform.position = pos;
//                }
//                if ( transform.position.z <= boundaryy_dw ) {
//                    pos.z = boundaryy_dw + 2;
//                    transform.position = pos;
//                }
                //Change movement direction
                movementDirection.z = -movementDirection.z;
            }
        }
    }
}
