using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpThreshold;
    
    [SerializeField] int playerIndex;
    // Start is called before the first frame update
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    
    public void setPosition(Vector3 pos)
    {
        transform.position = new Vector3(pos.x, transform.position.y, pos.z);
        
        //if ( pos.y > jumpThreshold ){
        //    transform.position = new Vector3(pos.x, transform.position.y + 5, pos.z);
        //}
    }
}

