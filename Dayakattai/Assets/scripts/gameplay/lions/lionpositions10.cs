using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lionpositions10 : MonoBehaviour
{
    public static lionpositions10 instance;
    public Transform[] position=new Transform[80];
    public GameObject[] circle = new GameObject[12];
    [SerializeField] private int p = 0, firstcount = 0, selectednumber = 0;
    public int i = 0, entrytosafezone = 0,boxcount=0,prevoiusposition;
    public bool playerboolmove, undestructable,canmove;
    public Vector2 defaultposition;
    private void Awake()
    {
        defaultposition = transform.position;
        canmove = false;
        playerboolmove = false;
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        for (int j = 0; j < 80; j++)
        {
            position[j] = lionposition1.instance.position[j];
        }
        for (int j = 0; j < 12; j++)
        {
            circle[j] = lionposition1.instance.circle[j];
        }
    }
    public void Move(Button button)
    {
        selectednumber = number.instance.global_number;
        StartCoroutine(move(selectednumber, button));
    }
    IEnumerator move(int steps, Button b)
    {
       
        entrytosafezone = steps + i;
        if (!playerboolmove)
        {
            if (!GameManager.instance.powerup5forsquare)
            {
                if (steps == 1)
                {
                    transform.position = position[i].transform.position;
                    b.transform.position = position[i].transform.position;
                   // positionsscript.instance.lionpiecetoposition(i);
                    i++;
                    playerboolmove = true;
                    GameManager.instance.powerup5forsquare = true;
                }
            }
            else
            {
                if (steps == 1 || steps == 5)
                {
                    transform.position = position[i].transform.position;
                    b.transform.position = position[i].transform.position;
                    //positionsscript.instance.lionpiecetoposition(i);
                    i++;
                    playerboolmove = true;
                }
            }
        }
        else
        {
            if (entrytosafezone == 7 || entrytosafezone == 13 || entrytosafezone == 19 || entrytosafezone == 25 || entrytosafezone == 31 || entrytosafezone == 37 || entrytosafezone == 43 || entrytosafezone == 49 || entrytosafezone == 55 || entrytosafezone == 67)
            {
                int r = entrytosafezone;
                if (r == 7)
                {
                    if (!safezone1.instance.circle_has_occupied)
                    {
                        canmove = true;
                    }

                    else
                    {
                        canmove = false;
                    }
                }
                if (r == 13)
                {
                    if (!safezone2.instance.circle_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 19)
                {
                    if (!safezone3.instance.circle_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 25)
                {
                    if (!safezone4.instance.circle_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 31)
                {
                    if (!safezone5.instance.circle_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 37)
                {
                    if (!safezone6.instance.circle_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 43)
                {
                    if (safezone7.instance.circle_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 49)
                {
                    if (!safezone8.instance.circle_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 55)
                {
                    if (!safezone9.instance.circle_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 67)
                {
                    if (!safezone10.instance.circle_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (canmove)
                {
                    if (entrytosafezone <= 80)
                    {
                      //  positionsscript.instance.removelion(i);
                        while (p < steps)
                        {
                            transform.position = position[i].transform.position;
                            b.transform.position = position[i].transform.position;
                            yield return new WaitForSeconds(0.25f);
                            p++;
                            i++;
                            if (i > 13)
                                boxcount++;
                            if (i > 59)
                                boxcount = 0;
                        }
                        //positionsscript.instance.lionpiecetoposition(i - 1);
                        //prevoiusposition = i - 1;
                    }
                    else
                    {
                        //positionsscript.instance.lionpiecetoposition(i - 1);
                       // prevoiusposition = i - 1;
                    }
                }

            }
            else
            {

                if (entrytosafezone <= 80)
                {
                    //positionsscript.instance.removelion(i);
                    while (p < steps)
                    {
                        transform.position = position[i].transform.position;
                        b.transform.position = position[i].transform.position;
                        yield return new WaitForSeconds(0.25f);
                        p++;
                        i++;
                        if (i > 13)
                            boxcount++;
                        if (i > 59)
                            boxcount = 0;
                    }
                    //positionsscript.instance.lionpiecetoposition(i-1);
                    //prevoiusposition = i-1;
                }
                else
                {
                   
                }

            }

        }

        if (steps == 1 || steps == 5 || steps == 6 || steps == 12)
        {
            number.instance.moving = false;
            number.instance.squareoncharge = true;
            number.instance.firstplayermove = false;
            number.instance.squaremoveenabled = false;

        }
        else
        {
            number.instance.moving = false;
            number.instance.squareoncharge = true;
            number.instance.firstplayermove = true;
            number.instance.squaremoveenabled = false;

        }
        if (playerboolmove)
        {
            checktackle(i);
        }
        p = 0;
        entrytosafezone = 0;

    }
    public void checktackle(int i)
    {
        if (number.instance.squareoncharge)
        {
            if ((i > 6 && i <= 13) || i > 60)
            {
                if (i == snakepositions1.instance.i && !snakepositions1.instance.undestructable)
                {
                    circle[0].transform.position = snakepositions1.instance.deafultposition;
                    circle[0].GetComponent<snakepositions1>().i = 0;
                    GameManager.instance.snakebutton[0].transform.position = snakepositions1.instance.deafultposition;
                    snakepositions1.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions1.instance.boxcount = 0;
                }
                if (i == snakepositions2.instance.i && !snakepositions2.instance.undestructable)
                {
                    circle[1].transform.position = snakepositions2.instance.defaultposition;
                    circle[1].GetComponent<snakepositions2>().i = 0;
                    GameManager.instance.snakebutton[1].transform.position = snakepositions2.instance.defaultposition;
                    snakepositions2.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions2.instance.boxcount = 0;
                }
                if (i == snakepositions3.instance.i && !snakepositions3.instance.undestructable)
                {
                    circle[2].transform.position = snakepositions3.instance.deafultposition;
                    circle[2].GetComponent<snakepositions3>().i = 0;
                    GameManager.instance.snakebutton[2].transform.position = snakepositions3.instance.deafultposition;
                    snakepositions4.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions3.instance.boxcount = 0;
                }
                if (i == snakepositions4.instance.i && !snakepositions4.instance.undestructable)
                {
                    circle[3].transform.position = snakepositions4.instance.deafultposition;
                    circle[3].GetComponent<snakepositions4>().i = 0;
                    GameManager.instance.snakebutton[2].transform.position = snakepositions4.instance.deafultposition;
                    snakepositions4.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions4.instance.boxcount = 0;
                }
                if (i == snakepositions5.instance.i && !snakepositions5.instance.undestructable)
                {
                    circle[4].transform.position = snakepositions5.instance.deafultposition;
                    circle[4].GetComponent<snakepositions5>().i = 0;
                    GameManager.instance.snakebutton[4].transform.position = snakepositions5.instance.deafultposition;
                    snakepositions5.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions5.instance.boxcount = 0;
                }
                if (i == snakepositions6.instance.i && !snakepositions6.instance.undestructable)
                {
                    circle[5].transform.position = snakepositions6.instance.deafultposition;
                    circle[5].GetComponent<snakepositions6>().i = 0;
                    GameManager.instance.snakebutton[2].transform.position = snakepositions6.instance.deafultposition;
                    snakepositions6.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions6.instance.boxcount = 0;
                }
                if (i == snakepositions7.instance.i && !snakepositions7.instance.undestructable)
                {
                    circle[6].transform.position = snakepositions7.instance.deafultposition;
                    circle[6].GetComponent<snakepositions7>().i = 0;
                    GameManager.instance.snakebutton[6].transform.position = snakepositions7.instance.deafultposition;
                    snakepositions7.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions7.instance.boxcount = 0;
                }
                if (i == snakepositions8.instance.i && !snakepositions8.instance.undestructable)
                {
                    circle[7].transform.position = snakepositions8.instance.deafultposition;
                    circle[7].GetComponent<snakepositions8>().i = 0;
                    GameManager.instance.snakebutton[7].transform.position = snakepositions8.instance.deafultposition;
                    snakepositions8.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions8.instance.boxcount = 0;
                }
                if (i == snakepositions9.instance.i && !snakepositions9.instance.undestructable)
                {
                    circle[8].transform.position = snakepositions9.instance.deafultposition;
                    circle[8].GetComponent<snakepositions9>().i = 0;
                    GameManager.instance.snakebutton[8].transform.position = snakepositions9.instance.deafultposition;
                    snakepositions9.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions9.instance.boxcount = 0;
                }
                if (i == snakepositions10.instance.i && !snakepositions10.instance.undestructable)
                {
                    circle[9].transform.position = snakepositions10.instance.deafultposition;
                    circle[9].GetComponent<snakepositions10>().i = 0;
                    GameManager.instance.snakebutton[9].transform.position = snakepositions10.instance.deafultposition;
                    snakepositions10.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions10.instance.boxcount = 0;
                }
                if (i == snakepositions11.instance.i && !snakepositions11.instance.undestructable)
                {

                    circle[10].transform.position = snakepositions11.instance.deafultposition;
                    circle[10].GetComponent<snakepositions11>().i = 0;
                    GameManager.instance.snakebutton[10].transform.position = snakepositions11.instance.deafultposition;
                    snakepositions11.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions11.instance.boxcount = 0;
                }
                if (i == snakepositions12.instance.i && !snakepositions12.instance.undestructable)
                {
                    circle[11].transform.position = snakepositions12.instance.deafultposition;
                    circle[11].GetComponent<snakepositions12>().i = 0;
                    GameManager.instance.snakebutton[11].transform.position = snakepositions12.instance.deafultposition;
                    snakepositions12.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions12.instance.boxcount = 0;
                }
            }
            if (i > 13 && i <= 59)
            {
                if (boxcount + snakepositions1.instance.boxcount == 48 && !snakepositions1.instance.undestructable)
                {
                    circle[0].transform.position = snakepositions1.instance.deafultposition;
                    circle[0].GetComponent<snakepositions1>().i = 0;
                    GameManager.instance.snakebutton[0].transform.position = snakepositions1.instance.deafultposition;
                    snakepositions1.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions1.instance.boxcount = 0;
                }
                if (boxcount + snakepositions2.instance.boxcount == 48 && !snakepositions2.instance.undestructable)
                {
                    circle[1].transform.position = snakepositions2.instance.defaultposition;
                    circle[1].GetComponent<snakepositions2>().i = 0;
                    GameManager.instance.snakebutton[1].transform.position = snakepositions2.instance.defaultposition;
                    snakepositions2.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions2.instance.boxcount = 0;
                }
                if (boxcount + snakepositions3.instance.boxcount == 48 && !snakepositions3.instance.undestructable)
                {
                    circle[2].transform.position = snakepositions3.instance.deafultposition;
                    circle[2].GetComponent<snakepositions3>().i = 0;
                    GameManager.instance.snakebutton[2].transform.position = snakepositions3.instance.deafultposition;
                    snakepositions4.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions3.instance.boxcount = 0;
                }
                if (boxcount + snakepositions4.instance.boxcount == 48 && !snakepositions4.instance.undestructable)
                {
                    circle[3].transform.position = snakepositions4.instance.deafultposition;
                    circle[3].GetComponent<snakepositions4>().i = 0;
                    GameManager.instance.snakebutton[2].transform.position = snakepositions4.instance.deafultposition;
                    snakepositions4.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions4.instance.boxcount = 0;
                }
                if (boxcount + snakepositions5.instance.boxcount == 48 && !snakepositions5.instance.undestructable)
                {
                    circle[4].transform.position = snakepositions5.instance.deafultposition;
                    circle[4].GetComponent<snakepositions5>().i = 0;
                    GameManager.instance.snakebutton[4].transform.position = snakepositions5.instance.deafultposition;
                    snakepositions5.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions5.instance.boxcount = 0;
                }
                if (boxcount + snakepositions6.instance.boxcount == 48 && !snakepositions6.instance.undestructable)
                {
                    circle[5].transform.position = snakepositions6.instance.deafultposition;
                    circle[5].GetComponent<snakepositions6>().i = 0;
                    GameManager.instance.snakebutton[2].transform.position = snakepositions6.instance.deafultposition;
                    snakepositions6.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions6.instance.boxcount = 0;
                }
                if (boxcount + snakepositions7.instance.boxcount == 48 && !snakepositions7.instance.undestructable)
                {
                    circle[6].transform.position = snakepositions7.instance.deafultposition;
                    circle[6].GetComponent<snakepositions7>().i = 0;
                    GameManager.instance.snakebutton[6].transform.position = snakepositions7.instance.deafultposition;
                    snakepositions7.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions7.instance.boxcount = 0;
                }
                if (boxcount + snakepositions8.instance.boxcount == 48 && !snakepositions8.instance.undestructable)
                {
                    circle[7].transform.position = snakepositions8.instance.deafultposition;
                    circle[7].GetComponent<snakepositions8>().i = 0;
                    GameManager.instance.snakebutton[7].transform.position = snakepositions8.instance.deafultposition;
                    snakepositions8.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions8.instance.boxcount = 0;
                }
                if (boxcount + snakepositions9.instance.boxcount == 48 && !snakepositions9.instance.undestructable)
                {
                    circle[8].transform.position = snakepositions9.instance.deafultposition;
                    circle[8].GetComponent<snakepositions9>().i = 0;
                    GameManager.instance.snakebutton[8].transform.position = snakepositions9.instance.deafultposition;
                    snakepositions9.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions9.instance.boxcount = 0;
                }
                if (boxcount + snakepositions10.instance.boxcount == 48 && !snakepositions10.instance.undestructable)
                {
                    circle[9].transform.position = snakepositions10.instance.deafultposition;
                    circle[9].GetComponent<snakepositions10>().i = 0;
                    GameManager.instance.snakebutton[9].transform.position = snakepositions10.instance.deafultposition;
                    snakepositions10.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions10.instance.boxcount = 0;
                }
                if (boxcount + snakepositions11.instance.boxcount == 48 && !snakepositions11.instance.undestructable)
                {

                    circle[10].transform.position = snakepositions11.instance.deafultposition;
                    circle[10].GetComponent<snakepositions11>().i = 0;
                    GameManager.instance.snakebutton[10].transform.position = snakepositions11.instance.deafultposition;
                    snakepositions11.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions11.instance.boxcount = 0;
                }
                if (boxcount + snakepositions12.instance.boxcount == 48 && !snakepositions12.instance.undestructable)
                {
                    circle[11].transform.position = snakepositions12.instance.deafultposition;
                    circle[11].GetComponent<snakepositions12>().i = 0;
                    GameManager.instance.snakebutton[11].transform.position = snakepositions12.instance.deafultposition;
                    snakepositions12.instance.snakeplayerstatus = false;
                    number.instance.firstplayermove = false;
                    snakepositions12.instance.boxcount = 0;
                }
            }
        }

    }


}
