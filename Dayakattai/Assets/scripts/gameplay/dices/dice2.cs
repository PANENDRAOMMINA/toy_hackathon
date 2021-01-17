using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dice2 : MonoBehaviour
{
    public Sprite[] diceslot;
    private Image i;
    public int f;
    public static dice2 instance;
    public bool diceroll;
    // Start is called before the first frame update
    private void Awake()
    {
        i = GetComponent<Image>();
        if(instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
   public void dicerolling()
    {
        f = Random.Range(0, 4);
        i.sprite = diceslot[f];
    }
    public void rolldice()
    {
        number.instance.dice_number2 = f;
    }

}
