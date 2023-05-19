using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
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
        //swith playerIndex
        //transform.position = pos;
        //transform.position = new Vector3(pos.x, transform.position.y, pos.z);
        transform.position = new Vector3(pos.x, 5, pos.z);
    }
}
