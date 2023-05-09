using UnityEngine;

public class collide : MonoBehaviour
{
    public GameObject platform;
    private movement movement_script;

    private void Start()
    {
        movement_script = platform.GetComponent<movement>();
    }

    private void Update()
    {

    }

    private void OnTriggerEnter (Collider other){
        if (other.CompareTag("Island") || other.CompareTag("Platform")){
            movement_script.movementDirection = -movement_script.movementDirection;
        }
    }

}
