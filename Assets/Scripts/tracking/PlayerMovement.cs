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

    // player_pos = -23
    // cube_pos_world = -12
    //
    //if pos.y > -22
    //      float jump_pos = pos.y + 11;
    
    public void setPosition(Vector3 pos)
    {
        transform.position = new Vector3(pos.x, transform.position.y, pos.z);
        
        //if ( pos.y > jumpThreshold ){
        //    transform.position = new Vector3(pos.x, transform.position.y + 5, pos.z);
        //}
        
        //swith playerIndex
        //transform.position = pos;
        //transform.position.x = pos.x;
        //transform.position.z = pos.z;
        //transform.position = new Vector3(pos.x, 5, pos.z);
    }

}

