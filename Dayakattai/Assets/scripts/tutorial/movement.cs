using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector2 v,a;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (i < 19)
            {
                transform.Translate(v);
                i++;
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (i > 0)
            {
                transform.Translate(a);
                i--;
            }
        }
    }
}
