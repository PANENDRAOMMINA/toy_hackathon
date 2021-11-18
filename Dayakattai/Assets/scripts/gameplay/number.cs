using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class number : MonoBehaviour
{

    // Start is called before the first frame update
    public static number instance;
    public GameObject Lifeline;
    public bool moving,firstplayermove,firstplace,squaremoveenabled;
    public bool squareoncharge,Lions_Lifeline,Snakes_Lifeline,lions_turn,snakes_turn;
    public int global_number=0,dice_number1,dice_number2;

    public GameObject Lions_taunt, vipers_taunt,_lions_turns,_snakes_turns;
    public int team_number_for_lions, team_number_for_vipers;
   
    
    private void Awake()
    {
        Lions_Lifeline = false;
        Snakes_Lifeline = false;
        squareoncharge=true;
        moving = false;
        if(instance==null)
        {
            instance = this;
        }
        lions_turn = true;
        snakes_turn = false;
        team_number_for_lions = -1;
        team_number_for_vipers = -1;
    }
 

    // Update is called once per frame
    void Update()
    {
        
        if(!moving)
        {
            dice.instance.dicerolling();
            dice2.instance.dicerolling();
            
            StartCoroutine(display_snakes_turn());
            StartCoroutine(display_lions_turn());
        }
        if (Input.GetKeyDown(KeyCode.Space) && !moving&&!FindObjectOfType<menumanager>().ispaused)
        {
            dice.instance.rolldice();
            dice2.instance.rolldice();
            

       
            if (!firstplayermove)//resembles the player one 
            {
        
                if ((dice_number1 == 0 && dice_number2 == 0) || (dice_number1 == 1 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 1))
                {
                    global_number = 2;
                    moving = true;
                }
                else if ((dice_number1 == 0 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 0))
                {
                    global_number = 1;
                    moving = false;
                }
                else if ((dice_number1 == 1 && dice_number2 == 0) || (dice_number1 == 0 && dice_number2 == 1) || (dice_number1 == 2 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 2))
                {
                    global_number = 3;
                    moving = true;
                }
                else if ((dice_number1 == 1 && dice_number2 == 1) || (dice_number1 == 0 && dice_number2 == 2) || (dice_number1 == 2 && dice_number2 == 0))
                {
                    global_number = 4;
                    moving = true;
                }
                else if ((dice_number1 == 2 && dice_number2 == 1) || (dice_number1 == 1 && dice_number2 == 2))
                {
                    global_number = 5;
                    moving = false;
                }
                else if ((dice_number1 == 2 && dice_number2 == 2))
                {
                    global_number = 6;
                    moving = false;
                }
                else if (dice_number2 == 3 && dice_number2 == 3)
                {
                    global_number = 12;
                    moving = false;
                }
                FindObjectOfType<button_creation>().Create_Button(global_number);
                squaremoveenabled = true;
            }
            else  // resembles player 2
            {
                dice.instance.rolldice();
                dice2.instance.rolldice();
                
                if ((dice_number1 == 0 && dice_number2 == 0) || (dice_number1 == 1 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 1))
                {
                    global_number = 2;
                    moving = true;
                }
                else if ((dice_number1 == 0 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 0))
                {
                    global_number = 1;
                    moving = false;
                }
                else if ((dice_number1 == 1 && dice_number2 == 0) || (dice_number1 == 0 && dice_number2 == 1) || (dice_number1 == 2 && dice_number2 == 3) || (dice_number1 == 3 && dice_number2 == 2))
                {
                    global_number = 3;
                    moving = true;

                }
                else if ((dice_number1 == 1 && dice_number2 == 1)||(dice_number1==2 && dice_number2==0)||(dice_number1==0&&dice_number2==2))
                {
                    global_number = 4;
                    moving = true;
                }
                else if ((dice_number1 == 2 && dice_number2 == 1) || (dice_number1 == 1 && dice_number2 == 2))
                {
                    global_number = 5;
                    moving = false;
                }
                else if (dice_number1 == 2 && dice_number2 == 2)
                {
                    global_number = 6;
                    moving = false;
                }
                else if (dice_number2 == 3 && dice_number2 == 3)
                {
                    global_number = 12;
                    moving = false;
                }
                FindObjectOfType<button_creation>().Create_Button(global_number);
                squaremoveenabled = false;
            }
           
         }
       

        if (Lions_Lifeline)
            Lions_taunt.SetActive(true);
        else
            Lions_taunt.SetActive(false);

        if (Snakes_Lifeline)
            vipers_taunt.SetActive(true);
        else
            Lions_taunt.SetActive(false);

        if(team_number_for_lions == PlayerPrefs.GetInt("Team_Size"))
            team_number_for_lions = 0;
        if (team_number_for_vipers == PlayerPrefs.GetInt("Team_Size"))
            team_number_for_vipers = 0;
        

        
    }
    public void Activate_Lifeline()
    {
        Lifeline.SetActive(true);
    }
    public void Deactivate_Lifeline()
    {
        Lifeline.SetActive(false);
        Lions_Lifeline = false;
        Snakes_Lifeline = false;
    }
    IEnumerator display_lions_turn()
    {
        if(lions_turn)
        {
            _lions_turns.SetActive(true);
            lions_turn = false;
            team_number_for_lions++;
            yield return new WaitForSecondsRealtime(2f);
            _lions_turns.SetActive(false);
           
        }
      
    }

    IEnumerator display_snakes_turn()
    {
        if (snakes_turn)
        {
            _snakes_turns.SetActive(true);
            snakes_turn = false;
            team_number_for_vipers++;
            yield return new WaitForSecondsRealtime(2f);
            _snakes_turns.SetActive(false);
            
        }
        
    }

}
