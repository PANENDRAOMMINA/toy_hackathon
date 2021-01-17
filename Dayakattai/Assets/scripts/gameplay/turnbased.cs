using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turnbased : MonoBehaviour
{
    public Image leftarrow,rightarrow,leftteam,rightteam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(number.instance.firstplayermove)
        {
            leftarrow.enabled = true;
            leftteam.enabled = true;
            rightarrow.enabled = false;
            rightteam.enabled = false;
        }
        else
        {
            leftarrow.enabled = false;
            leftteam.enabled = false;
            rightarrow.enabled = true;
            rightteam.enabled = true;
        }
    }
}
