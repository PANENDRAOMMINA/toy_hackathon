using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector2 local_position;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        local_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            
                Vector2 move_vector = new Vector2(8,0);
                local_position += move_vector*Time.deltaTime;
                transform.position = local_position;
                
            
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
           
                Vector2 move_vector = new Vector2(-8, 0);
                local_position += move_vector*Time.deltaTime;
                transform.position = local_position;
                
            
        }
    }
}
