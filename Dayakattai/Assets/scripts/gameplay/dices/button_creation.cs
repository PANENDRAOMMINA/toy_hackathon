using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_creation : MonoBehaviour
{

    public GameObject button;
    public GameObject button_parent;
    public float Pos_x=-80;
    public float Pos_Y =150f;

    public List<_Button> buttons = new List<_Button>();

    
    public void Create_Button(int number)
    { 
        GameObject _button = Instantiate(button) as GameObject;
        _button.transform.SetParent(button_parent.transform,false);
        _button.GetComponent<RectTransform>().anchoredPosition = new Vector3(Pos_x, Pos_Y,0);
        _button.GetComponent<_Button>().give_number(number);
        Pos_x += 80f;
        if(Pos_x>100f)
        {
            Pos_x = -80f;
            Pos_Y -= 50f;
        }
      
    }
    public void Reset_positions()
    {
        Pos_x = -80;
        Pos_Y = 150f;
    }


}
