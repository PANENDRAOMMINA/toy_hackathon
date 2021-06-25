using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class menumanager : MonoBehaviour
{

    public GameObject are_you_sure;
    public bool ispaused;
    public TMP_InputField team_size;
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
    public void exit()
    {
        Application.Quit();
    }
    public void enable_are_you_sure()
    {
        are_you_sure.SetActive(true);
        ispaused = true;
    }
    public void disable_are_you_sure()
    {
        are_you_sure.SetActive(false);
        ispaused = false;
    }

    public void Update_Team_Size(string name)
    {
        PlayerPrefs.SetInt("Team_Size", Convert.ToInt32(name));
    }

}
