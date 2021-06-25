using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class _Button : MonoBehaviour
{
    public TMP_Text text;
    private button_creation creation;
    public bool isselected;

    public int express
    {
        get
        {
            return number;
        }
    }

    public int number;

    public void Awake()
    {
        creation = FindObjectOfType<button_creation>();
        creation.buttons.Add(this.gameObject.GetComponent<_Button>());
    }

    public void Update()
    {
        text.text = number.ToString();
    }

    public void give_number(int n)
    {
        number = n;
    }
    public void Selected()
    {
        for (int i = 0; i < creation.buttons.Count; i++)
        {
            FindObjectOfType<button_creation>().buttons[i].isselected = false;
        }
        isselected = true;
    }
    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
