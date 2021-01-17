﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class snakepositions5 : MonoBehaviour
{
    public static snakepositions5 instance;
    public Transform[] position = new Transform[80];
    public Vector2 deafultposition;
    public GameObject[] box = new GameObject[12];


    [SerializeField] private int p = 0, firstcount = 0, selectednumber = 0, entrysafezone = 0;
    public bool snakeplayerstatus, undestructable,canmove;
    public int i = 0,boxcount=0,previousnumber;

    private void Awake()
    {
        deafultposition = transform.position;

        snakeplayerstatus = false;
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int j = 0; j < 80; j++)
        {
            position[j] = snakepositions1.instance.position[j];
        }
        for (int j = 0; j < 12; j++)
        {
            box[j] = snakepositions1.instance.box[j];
        }
    }
    public void Move(Button button)
    {
        selectednumber = number.instance.global_number;
        StartCoroutine(move(selectednumber, button));
    }
    IEnumerator move(int steps, Button b)
    {
      
        entrysafezone = steps + i;
        if (!snakeplayerstatus)
        {
            if (!GameManager.instance.powerup5forcircle)
            {
                if (steps == 1)
                {
                    transform.position = position[i].transform.position;
                    b.transform.position = position[i].transform.position;
                   // positionsscript.instance.snakepieceposition(i);
                    i++;
                    snakeplayerstatus = true;
                    GameManager.instance.powerup5forcircle = true;
                }
            }
            else
            {
                if (steps == 1 || steps == 5)
                {
                    transform.position = position[i].transform.position;
                    b.transform.position = position[i].transform.position;
                  //  positionsscript.instance.snakepieceposition(i);
                    i++;
                    snakeplayerstatus = true;
                }

            }
        }
        else
        {
            if (entrysafezone == 7 || entrysafezone == 13 || entrysafezone == 19 || entrysafezone == 25 || entrysafezone == 31 || entrysafezone == 37 || entrysafezone == 43 || entrysafezone == 49 || entrysafezone == 55 || entrysafezone == 67)
            {
                int r = entrysafezone;
                if (r == 7)
                {
                    if (!safezone1.instance.square_has_occupied)
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
                    if (!safezone2.instance.square_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 19)
                {
                    if (!safezone3.instance.square_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 25)
                {
                    if (!safezone4.instance.square_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 31)
                {
                    if (!safezone5.instance.square_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 37)
                {
                    if (!safezone6.instance.square_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 43)
                {
                    if (!safezone7.instance.square_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 49)
                {
                    if (!safezone8.instance.square_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 55)
                {
                    if (!safezone9.instance.square_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (r == 67)
                {
                    if (!safezone10.instance.square_has_occupied)
                        canmove = true;
                    else
                        canmove = false;
                }
                if (canmove)
                {
                    if (entrysafezone <= 80)
                    {
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
                       // positionsscript.instance.snakepieceposition(i - 1);
                      //  previousnumber = i - 1;
                    }
                    else
                    {
                      //  positionsscript.instance.snakepieceposition(i - 1);
                       // previousnumber = i - 1;
                    }
                }

            }
            else
            {
                if (entrysafezone <= 80)
                {
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
                   // positionsscript.instance.snakepieceposition(i - 1);
                   // previousnumber = i - 1;
                }
                else
                {

                }

            }


        }


        if (steps == 1 || steps == 5 || steps == 6 || steps == 12)
        {
            number.instance.moving = false;
            number.instance.squareoncharge = false;
            number.instance.firstplayermove = true;
            number.instance.squaremoveenabled = true;
        }
        else
        {
            number.instance.moving = false;
            number.instance.squareoncharge = false;
            number.instance.firstplayermove = false;
            number.instance.squaremoveenabled = true;
        }
        if (snakeplayerstatus)
        {
            checktackle(i);
        }
        p = 0;
        entrysafezone = 0;
        canmove = false;

    }

    public void checktackle(int i)
    {
        if (!number.instance.squareoncharge)
        {
            if ((i > 6 && i <= 13) || i > 60)
            {
                if (i == lionposition1.instance.i && !lionposition1.instance.undestructable)
                {
                    box[0].transform.position = lionposition1.instance.defaultposition;
                    box[0].GetComponent<lionposition1>().i = 0;
                    GameManager.instance.lionbutton[0].transform.position = lionposition1.instance.defaultposition;
                    lionposition1.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionposition1.instance.boxcount = 0;
                }
                if (i == lionposition2.instance.i && !lionposition2.instance.undestructable)
                {
                    box[1].transform.position = lionposition2.instance.defaultposition;
                    box[1].GetComponent<lionposition2>().i = 0;
                    GameManager.instance.lionbutton[1].transform.position = lionposition2.instance.defaultposition;
                    lionposition2.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionposition2.instance.boxcount = 0;
                }
                if (i == lionpositions3.instance.i && !lionpositions3.instance.undestructable)
                {
                    box[2].transform.position = lionpositions3.instance.defaultposition;
                    box[2].GetComponent<lionpositions3>().i = 0;
                    GameManager.instance.lionbutton[2].transform.position = lionpositions3.instance.defaultposition;
                    lionpositions3.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions3.instance.boxcount = 0;
                }
                if (i == lionpositions4.instance.i && !lionpositions4.instance.undestructable)
                {
                    box[3].transform.position = lionpositions4.instance.defaultposition;
                    box[3].GetComponent<lionpositions4>().i = 0;
                    GameManager.instance.lionbutton[3].transform.position = lionpositions4.instance.defaultposition;
                    lionpositions4.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions4.instance.boxcount = 0;
                }
                if (i == lionpositions5.instance.i && !lionpositions5.instance.undestructable)
                {
                    box[4].transform.position = lionpositions5.instance.defaultposition;
                    box[4].GetComponent<lionpositions5>().i = 0;
                    GameManager.instance.lionbutton[3].transform.position = lionpositions5.instance.defaultposition;
                    lionpositions5.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions5.instance.boxcount = 0;
                }

                if (i == lionpositions6.instance.i && !lionpositions6.instance.undestructable)
                {
                    box[5].transform.position = lionpositions6.instance.defaultposition;
                    box[5].GetComponent<lionpositions6>().i = 0;
                    GameManager.instance.lionbutton[6].transform.position = lionpositions6.instance.defaultposition;
                    lionpositions6.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions6.instance.boxcount = 0;
                }
                if (i == lionpositions7.instance.i && !lionpositions7.instance.undestructable)
                {
                    box[6].transform.position = lionpositions7.instance.defaultposition;
                    box[6].GetComponent<lionpositions7>().i = 0;
                    GameManager.instance.lionbutton[7].transform.position = lionpositions7.instance.defaultposition;
                    lionpositions7.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions7.instance.boxcount = 0;
                }
                if (i == lionpositions8.instance.i && !lionpositions8.instance.undestructable)
                {
                    box[7].transform.position = lionpositions8.instance.defaultposition;
                    box[7].GetComponent<lionpositions8>().i = 0;
                    GameManager.instance.lionbutton[7].transform.position = lionpositions8.instance.defaultposition;
                    lionpositions8.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions8.instance.boxcount = 0;
                }
                if (i == lionpositions9.instance.i && !lionpositions9.instance.undestructable)
                {
                    box[8].transform.position = lionpositions9.instance.defaultposition;
                    box[8].GetComponent<lionpositions9>().i = 0;
                    GameManager.instance.lionbutton[8].transform.position = lionpositions9.instance.defaultposition;
                    lionpositions8.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions9.instance.boxcount = 0;
                }
                if (i == lionpositions10.instance.i && !lionpositions10.instance.undestructable)
                {
                    box[9].transform.position = lionpositions10.instance.defaultposition;
                    box[9].GetComponent<lionpositions10>().i = 0;
                    GameManager.instance.lionbutton[9].transform.position = lionpositions10.instance.defaultposition;
                    lionpositions8.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions10.instance.boxcount = 0;
                }
                if (i == lionpositions11.instance.i && !lionpositions11.instance.undestructable)
                {
                    box[10].transform.position = lionpositions11.instance.defaultposition;
                    box[10].GetComponent<lionpositions11>().i = 0;
                    GameManager.instance.lionbutton[10].transform.position = lionpositions11.instance.defaultposition;
                    lionpositions11.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions11.instance.boxcount = 0;
                }
                if (i == lionpositions12.instance.i && !lionpositions12.instance.undestructable)
                {
                    box[11].transform.position = lionpositions12.instance.defaultposition;
                    box[11].GetComponent<lionpositions12>().i = 0;
                    GameManager.instance.lionbutton[11].transform.position = lionpositions12.instance.defaultposition;
                    lionpositions12.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions12.instance.boxcount = 0;
                }
            }
            if (i > 13 && i <= 59)
            {
                if (boxcount + lionposition1.instance.boxcount == 48 && !lionposition1.instance.undestructable)
                {
                    box[0].transform.position = lionposition1.instance.defaultposition;
                    box[0].GetComponent<lionposition1>().i = 0;
                    GameManager.instance.lionbutton[0].transform.position = lionposition1.instance.defaultposition;
                    lionposition1.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionposition1.instance.boxcount = 0;
                }
                if (boxcount + lionposition2.instance.boxcount == 48 && !lionposition2.instance.undestructable)
                {
                    box[1].transform.position = lionposition2.instance.defaultposition;
                    box[1].GetComponent<lionposition2>().i = 0;
                    GameManager.instance.lionbutton[1].transform.position = lionposition2.instance.defaultposition;
                    lionposition2.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionposition2.instance.boxcount = 0;
                }
                if (boxcount + lionpositions3.instance.boxcount == 48 && !lionpositions3.instance.undestructable)
                {
                    box[2].transform.position = lionpositions3.instance.defaultposition;
                    box[2].GetComponent<lionpositions3>().i = 0;
                    GameManager.instance.lionbutton[2].transform.position = lionpositions3.instance.defaultposition;
                    lionpositions3.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions3.instance.boxcount = 0;
                }
                if (boxcount + lionpositions4.instance.boxcount == 48 && !lionpositions4.instance.undestructable)
                {
                    box[3].transform.position = lionpositions4.instance.defaultposition;
                    box[3].GetComponent<lionpositions4>().i = 0;
                    GameManager.instance.lionbutton[3].transform.position = lionpositions4.instance.defaultposition;
                    lionpositions4.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions4.instance.boxcount = 0;
                }
                if (boxcount + lionpositions5.instance.boxcount == 48 && !lionpositions5.instance.undestructable)
                {
                    box[4].transform.position = lionpositions5.instance.defaultposition;
                    box[4].GetComponent<lionpositions5>().i = 0;
                    GameManager.instance.lionbutton[3].transform.position = lionpositions5.instance.defaultposition;
                    lionpositions5.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions5.instance.boxcount = 0;
                }
                if (boxcount + lionpositions6.instance.boxcount == 48 && !lionpositions6.instance.undestructable)
                {
                    box[5].transform.position = lionpositions6.instance.defaultposition;
                    box[5].GetComponent<lionpositions6>().i = 0;
                    GameManager.instance.lionbutton[6].transform.position = lionpositions6.instance.defaultposition;
                    lionpositions6.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions6.instance.boxcount = 0;
                }
                if (boxcount + lionpositions7.instance.boxcount == 48 && !lionpositions7.instance.undestructable)
                {
                    box[6].transform.position = lionpositions7.instance.defaultposition;
                    box[6].GetComponent<lionpositions7>().i = 0;
                    GameManager.instance.lionbutton[7].transform.position = lionpositions7.instance.defaultposition;
                    lionpositions7.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions7.instance.boxcount = 0;
                }
                if (boxcount + lionpositions8.instance.boxcount == 48 && !lionpositions8.instance.undestructable)
                {
                    box[7].transform.position = lionpositions8.instance.defaultposition;
                    box[7].GetComponent<lionpositions8>().i = 0;
                    GameManager.instance.lionbutton[7].transform.position = lionpositions8.instance.defaultposition;
                    lionpositions8.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions8.instance.boxcount = 0;
                }
                if (boxcount + lionpositions9.instance.boxcount == 48 && !lionpositions9.instance.undestructable)
                {
                    box[8].transform.position = lionpositions9.instance.defaultposition;
                    box[8].GetComponent<lionpositions9>().i = 0;
                    GameManager.instance.lionbutton[8].transform.position = lionpositions9.instance.defaultposition;
                    lionpositions8.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions9.instance.boxcount = 0;
                }
                if (boxcount + lionpositions10.instance.boxcount == 48 && !lionpositions10.instance.undestructable)
                {
                    box[9].transform.position = lionpositions10.instance.defaultposition;
                    box[9].GetComponent<lionpositions10>().i = 0;
                    GameManager.instance.lionbutton[9].transform.position = lionpositions10.instance.defaultposition;
                    lionpositions8.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions10.instance.boxcount = 0;
                }
                if (boxcount + lionpositions11.instance.boxcount == 48 && !lionpositions11.instance.undestructable)
                {
                    box[10].transform.position = lionpositions11.instance.defaultposition;
                    box[10].GetComponent<lionpositions11>().i = 0;
                    GameManager.instance.lionbutton[10].transform.position = lionpositions11.instance.defaultposition;
                    lionpositions11.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions11.instance.boxcount = 0;
                }
                if (boxcount + lionpositions12.instance.boxcount == 48 && !lionpositions12.instance.undestructable)
                {
                    box[11].transform.position = lionpositions12.instance.defaultposition;
                    box[11].GetComponent<lionpositions12>().i = 0;
                    GameManager.instance.lionbutton[11].transform.position = lionpositions12.instance.defaultposition;
                    lionpositions12.instance.playerboolmove = false;
                    number.instance.firstplayermove = true;
                    lionpositions12.instance.boxcount = 0;
                }

            }
        }



    }


}

