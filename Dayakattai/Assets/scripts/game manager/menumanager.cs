using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    public void mode()
    {
        SceneManager.LoadScene(1);
    }
    public void fourplayermode()
    {
        SceneManager.LoadScene(3);
    }

    public void gameplay()
    {
        SceneManager.LoadScene(2);
    }
    public void history()
    {
        SceneManager.LoadScene(5);
    }
   
    public void help()
    {
        SceneManager.LoadScene(6);
    }
    public void about()
    {
        SceneManager.LoadScene(4);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
