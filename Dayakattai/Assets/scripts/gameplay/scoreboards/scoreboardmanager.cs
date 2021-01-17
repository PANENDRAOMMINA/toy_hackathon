using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboardmanager : MonoBehaviour
{
    public Text vipertext;
    public Text liontext;
    public GameObject teamlions;
    public GameObject teamvipers;
    public static scoreboardmanager instance;

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vipertext.text = winningscript.instance.vipers.ToString();
        liontext.text = winningscript.instance.lions.ToString();
    }
}
