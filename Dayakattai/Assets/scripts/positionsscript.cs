using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class positionsscript : MonoBehaviour
{

    public int number = 0;



    public void Update()
    {
        GetComponent<TextMeshPro>().text = number.ToString();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "lion1")
        {
            number++;
        }
        if (collision.gameObject.tag == "lion2")
        {
            number++;
        }
        if (collision.gameObject.tag == "lion3")
        {
            number++;
        }
        if (collision.gameObject.tag == "lion4")
        {
        
            number++;
        }
        if (collision.gameObject.tag == "lion5")
        {
           
            number++;
        }
        if (collision.gameObject.tag == "lion6")
        {
           
            number++;
        }
        if (collision.gameObject.tag == "lion7")
        {
           
            number++;
        }
        if (collision.gameObject.tag == "lion8")
        {
           
            number++;
        }
        if (collision.gameObject.tag == "lion9")
        {
          
            number++;
        }
        if (collision.gameObject.tag == "lion10")
        {
           
            number++;
        }
        if (collision.gameObject.tag == "lion11")
        {
          
            number++;
        }
        if (collision.gameObject.tag == "lion12")
        {
          
            number++;
        }
        if (collision.gameObject.CompareTag("snake1"))
        {
            Debug.Log("collided");
            number++;
        }
        if (collision.gameObject.CompareTag("snake2"))
        {
            Debug.Log("Collided");
            number++;
        }
        if (collision.gameObject.CompareTag("snake3"))
        { 
            number++;
        }
        if (collision.gameObject.CompareTag("snake4"))
        { 
            number++;
        }
        if (collision.gameObject.CompareTag("snake5"))
        {
            
            number++;
        }
        if (collision.gameObject.CompareTag("snake6"))
        {
          
            number++;
        }
        if (collision.gameObject.CompareTag("snake7"))
        {
      
            number++;
        }
        if (collision.gameObject.tag == "snake8")
        {
           
            number++;
        }
        if (collision.gameObject.tag == "snake9")
        {
          
            number++;
        }
        if (collision.gameObject.tag == "snake10")
        {
          
            number++;
        }
        if (collision.gameObject.tag == "snake11")
        {
        
            number++;
        }
        if (collision.gameObject.tag == "snake12")
        {
            
            number++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "lion1")
        {
         
            number--;

        }
        if (collision.gameObject.tag == "lion2")
        {
            
            number--;
        }
        if (collision.gameObject.tag == "lion3")
        {
           
            number--;
        }
        if (collision.gameObject.tag == "lion4")
        {
        
            number--;
        }
        if (collision.gameObject.tag == "lion5")
        {
       
            number--;
        }
        if (collision.gameObject.tag == "lion6")
        {
           
            number--;
        }
        if (collision.gameObject.tag == "lion7")
        {
          
            number--;
        }
        if (collision.gameObject.tag == "lion8")
        {
        
            number--;
        }
        if (collision.gameObject.tag == "lion9")
        {
         
            number--;
        }
        if (collision.gameObject.tag == "lion10")
        {
        
            number--;
        }
        if (collision.gameObject.tag == "lion11")
        {
           
            number--;
        }
        if (collision.gameObject.tag == "lion12")
        {
           
            number--;
        }

        if (collision.gameObject.tag == "snake1")
        {
          
            number--;
        }
        if (collision.gameObject.tag == "snake2")
        {
            
            number--;
        }
        if (collision.gameObject.tag == "snake3")
        {
        
            number--;
        }
        if (collision.gameObject.tag == "snake4")
        {
          
            number--;
        }
        if (collision.gameObject.tag == "snake5")
        {
           
            number--;
        }
        if (collision.gameObject.tag == "snake6")
        {
          
            number--;
        }
        if (collision.gameObject.tag == "snake7")
        {
          
            number--;
        }
        if (collision.gameObject.tag == "snake8")
        {
          
            number--;
        }
        if (collision.gameObject.tag == "snake9")
        {
           
            number--;
        }
        if (collision.gameObject.tag == "snake10")
        {
       
            number--;
        }
        if (collision.gameObject.tag == "snake11")
        {
          
            number--;
        }
        if (collision.gameObject.tag == "snake12")
        {
            
            number--;
        }

    }

}
