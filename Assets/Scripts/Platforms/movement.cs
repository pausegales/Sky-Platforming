using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
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
