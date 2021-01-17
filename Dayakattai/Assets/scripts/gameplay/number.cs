using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class number : MonoBehaviour
{
    // Start is called before the first frame update
    public static number instance;
    public bool moving,firstplayermove,firstplace,squaremoveenabled;
    public bool squareoncharge;
    public int global_number=0,dice_number1,dice_number2;
    
    
    private void Awake()
    {
        squareoncharge=true;
        moving = false;
        if(instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if  (!moving)
        {
            dice.instance.dicerolling();
            dice2.instance.dicerolling();
        }
        if (Input.GetKeyDown(KeyCode.Space) && !moving)
        {
            dice.instance.rolldice();
            dice2.instance.rolldice();
       
            if (!firstplayermove)//resembles the player one 
            {
        
                if ((dice_number1 == 0 && dice_number2 == 0) || (dice_number1 == 1 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 1))
                {
                    global_number = 2;
                }
                else if ((dice_number1 == 0 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 0))
                {
                    global_number = 1;
                }
                else if ((dice_number1 == 1 && dice_number2 == 0) || (dice_number1 == 0 && dice_number2 == 1) || (dice_number1 == 2 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 2))
                {
                    global_number = 3;
                }
                else if ((dice_number1 == 1 && dice_number2 == 1) || (dice_number1 == 0 && dice_number2 == 2) || (dice_number1 == 2 && dice_number2 == 0))
                {
                    global_number = 4;
                }
                else if ((dice_number1 == 2 && dice_number2 == 1) || (dice_number1 == 1 && dice_number2 == 2))
                {
                    global_number = 5;
                }
                else if ((dice_number1 == 2 && dice_number2 == 2))
                {
                    global_number = 6;
                }
                else if (dice_number2 == 3 && dice_number2 == 3)
                {
                    global_number = 12;
                }
               squaremoveenabled = true;
            }
            else  // resembles player 2
            {
                dice.instance.rolldice();
                dice2.instance.rolldice();
                if ((dice_number1 == 0 && dice_number2 == 0) || (dice_number1 == 1 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 1))
                {
                    global_number = 2;
                }
                else if ((dice_number1 == 0 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 0))
                {
                    global_number = 1;
                }
                else if ((dice_number1 == 1 && dice_number2 == 0) || (dice_number1 == 0 && dice_number2 == 1) || (dice_number1 == 2 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 2))
                {
                    global_number = 3;
                }
                else if ((dice_number1 == 1 && dice_number2 == 1)||(dice_number1==2 && dice_number2==0)||(dice_number1==0&&dice_number2==2))
                {
                    global_number = 4;
                }
                else if ((dice_number1 == 2 && dice_number2 == 1) || (dice_number1 == 1 && dice_number2 == 2))
                {
                    global_number = 5;
                }
                else if (dice_number1 == 2 && dice_number2 == 2)
                {
                    global_number = 6;
                }
                else if (dice_number2 == 3 && dice_number2 == 3)
                {
                    global_number = 12;
                }
                squaremoveenabled = false;
            }
            
            moving = true;
         }
    }
  


}
