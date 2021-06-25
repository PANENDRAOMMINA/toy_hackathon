using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dice : MonoBehaviour
{

    public Sprite[] diceslot;
    private Image i;
    public int f;
    public static dice instance;
    // Start is called before the first frame update
    private void Awake()
    {
        i = GetComponent<Image>();
        if(instance==null)
        {
            instance = this;
        }
    }
    
    public void dicerolling()
    {
        f = Random.Range(0, 4);
        i.sprite = diceslot[f];
    }

    public void rolldice()
    {
        number.instance.dice_number1 = f;
    }
}
