using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Button[] snakebutton;
    public Button[] lionbutton;
    public bool powerup5forsquare, powerup5forcircle;
    public GameObject holder;
     private void Awake()
    {
        
        powerup5forcircle = false;
        powerup5forsquare = false;
        if(instance==null)
        {
            instance = this;
        }
        else
        {
            DontDestroyOnLoad(holder);
        }
    }
    public void letmovesquare()
    {
        if (number.instance.squaremoveenabled && !number.instance.firstplayermove)
        {
            lionposition1.instance.Move(lionbutton[0]);
        }
    }
    public void letmovesquare2()
    {
        if (number.instance.squaremoveenabled&&!number.instance.firstplayermove)
        {
            lionposition2.instance.Move(lionbutton[1]);
        }
    }
    public void letmovesquare3()
    {
        if(number.instance.squaremoveenabled&&!number.instance.firstplayermove)
        {
            lionpositions3.instance.Move(lionbutton[2]);
        }
    }
    public void letmovesquare4()
    {
        if (number.instance.squaremoveenabled && !number.instance.firstplayermove)
        {
            lionpositions4.instance.Move(lionbutton[3]);
        }
    }
    public void letmovesquare5()
    {
        if (number.instance.squaremoveenabled && !number.instance.firstplayermove)
        {
            lionpositions5.instance.Move(lionbutton[4]);
        }
    }
    public void letmovesquare6()
    {
        if (number.instance.squaremoveenabled && !number.instance.firstplayermove)
        {
            lionpositions6.instance.Move(lionbutton[5]);
        }
    }
    public void letmovesquare7()
    {
        if (number.instance.squaremoveenabled && !number.instance.firstplayermove)
        {
            lionpositions7.instance.Move(lionbutton[6]);
        }
    }
    public void letmovesquare8()
    {
        if (number.instance.squaremoveenabled && !number.instance.firstplayermove)
        {
            lionpositions8.instance.Move(lionbutton[7]);
        }
    }
    public void letmovesquare9()
    {
        if (number.instance.squaremoveenabled && !number.instance.firstplayermove)
        {
            lionpositions9.instance.Move(lionbutton[8]);
        }
    }
    public void letmovesquare10()
    {
        if (number.instance.squaremoveenabled && !number.instance.firstplayermove)
        {
            lionpositions10.instance.Move(lionbutton[9]);
        }
    }
    public void letmovesquare11()
    {
        if (number.instance.squaremoveenabled && !number.instance.firstplayermove)
        {
            lionpositions11.instance.Move(lionbutton[10]);
        }
    }
    public void letmovesquare12()
    {
        if (number.instance.squaremoveenabled && !number.instance.firstplayermove)
        {
            lionpositions12.instance.Move(lionbutton[11]);
        }
    }
    public void  letmovecircle()
    {
        if (!number.instance.squaremoveenabled&& number.instance.firstplayermove)
        {
            snakepositions1.instance.Move(snakebutton[0]);
        }
    }
    public void letmovecircle2()
    {
        if (!number.instance.squaremoveenabled&& number.instance.firstplayermove)
        {
            snakepositions2.instance.Move(snakebutton[1]);

        }
    }
    public void letmovecircle3()
    {
        if (!number.instance.squaremoveenabled && number.instance.firstplayermove)
        {
            snakepositions3.instance.Move(snakebutton[2]);

        }
    }
    public void letmovecircle4()
    {
        if (!number.instance.squaremoveenabled && number.instance.firstplayermove)
        {
            snakepositions4.instance.Move(snakebutton[3]);

        }
    }
    public void letmovecircle5()
    {
        if (!number.instance.squaremoveenabled && number.instance.firstplayermove)
        {
            snakepositions5.instance.Move(snakebutton[4]);

        }
    }
    public void letmovecircle6()
    {
        if (!number.instance.squaremoveenabled && number.instance.firstplayermove)
        {
            snakepositions6.instance.Move(snakebutton[5]);

        }
    }
    public void letmovecircle7()
    {
        if (!number.instance.squaremoveenabled && number.instance.firstplayermove)
        {
            snakepositions7.instance.Move(snakebutton[6]);

        }
    }
    public void letmovecircle8()
    {
        if (!number.instance.squaremoveenabled && number.instance.firstplayermove)
        {
            snakepositions8.instance.Move(snakebutton[7]);

        }
    }
    public void letmovecircle9()
    {
        if (!number.instance.squaremoveenabled && number.instance.firstplayermove)
        {
            snakepositions9.instance.Move(snakebutton[8]);

        }
    }
    public void letmovecircle10()
    {
        if (!number.instance.squaremoveenabled && number.instance.firstplayermove)
        {
            snakepositions10.instance.Move(snakebutton[9]);
        }
    }
    public void letmovecircle11()
    {
        if (!number.instance.squaremoveenabled && number.instance.firstplayermove)
        {
            snakepositions11.instance.Move(snakebutton[10]);
        }
    }
    public void letmovecircle12()
    {
        if (!number.instance.squaremoveenabled && number.instance.firstplayermove)
        {
            snakepositions12.instance.Move(snakebutton[11]);

        }
    }
}
