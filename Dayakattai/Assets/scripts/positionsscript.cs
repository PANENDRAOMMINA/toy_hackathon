using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class positionsscript : MonoBehaviour
{

    public int[] lionnumber;
    public int[] snakenumber;
    public Text[] lionlext;
    public Text[] snaketext;
    


    private void Awake()
    {
        lionnumber = new int[80];
        snakenumber = new int[80];
        lionlext = new Text[80];
        snaketext = new Text[80];
       

    }
    private void Start()
    {
      
    }
    public void lionpiecetoposition(int x)
    {
        for(int i=0;i<80;i++)
        {
            if (i==x)
            {
                Debug.Log(x);
                lionnumber[i]++;
                lionlext[i].text = lionnumber[i].ToString();
            }
        }
    }
    public void snakepieceposition(int x)
    {
        for (int i = 0; i < 80; i++)
        {
            if (i == x)
            {
                snakenumber[i]++;
                snaketext[i].text = snakenumber[i].ToString();
            }
        }
    }
    public void removelion(int x)
    {
        for (int i = 0; i < 80; i++)
        {
            if (i == x)
            {
                lionnumber[i]--;
                lionlext[i].text = lionnumber[i].ToString();
            }
        }
    }
    public void removesnake(int x)
    {
        for (int i = 0; i < 80; i++)
        {
            if (i == x)
            {
                snakenumber[i]--;
                snaketext[i].text = snakenumber[i].ToString();
           
            }
        }
    }

}
