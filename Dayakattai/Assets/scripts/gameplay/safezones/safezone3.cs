using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safezone3 : MonoBehaviour
{
    public bool zone_has_occupied;
    public bool circle_has_occupied;
    public bool square_has_occupied;
    public int snakesnumber = 0;
    public int lionsnumber = 0;

    public static safezone3 instance;

    // Start is called before the first frame update

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        zone_has_occupied = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (lionsnumber > 0)
        {
            zone_has_occupied = true;
            square_has_occupied = true;
        }
        else
        {
            square_has_occupied = false;
            zone_has_occupied = false;
        }
        if (snakesnumber > 0)
        {
            zone_has_occupied = true;
            circle_has_occupied = true;
        }
        else
        {
            zone_has_occupied = false;
            circle_has_occupied = false;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "lion1")
        {
            lionposition1.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion2")
        {
            lionposition2.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion3")
        {
            lionpositions3.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion4")
        {
            lionpositions4.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion5")
        {
            lionpositions5.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion6")
        {
            lionpositions6.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion7")
        {
            lionpositions7.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion8")
        {
            lionpositions8.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion9")
        {
            lionpositions9.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion10")
        {
            lionpositions10.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion11")
        {
            lionpositions11.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "lion12")
        {
            lionpositions12.instance.undestructable = true;
            lionsnumber++;
        }
        if (collision.gameObject.tag == "snake1")
        {
            snakepositions1.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake2")
        {
            snakepositions2.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake3")
        {
            snakepositions3.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake4")
        {
            snakepositions4.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake5")
        {
            snakepositions5.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake6")
        {
            snakepositions6.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake7")
        {
            snakepositions7.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake8")
        {
            snakepositions8.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake9")
        {
            snakepositions9.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake10")
        {
            snakepositions10.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake11")
        {
            snakepositions11.instance.undestructable = true;
            snakesnumber++;
        }
        if (collision.gameObject.tag == "snake12")
        {
            snakepositions12.instance.undestructable = true;
            snakesnumber++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "lion1")
        {
            lionposition1.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion2")
        {
            lionposition2.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion3")
        {
            lionpositions3.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion4")
        {
            lionpositions4.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion5")
        {
            lionpositions5.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion6")
        {
            lionpositions6.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion7")
        {
            lionpositions7.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion8")
        {
            lionpositions8.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion9")
        {
            lionpositions9.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion10")
        {
            lionpositions10.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion11")
        {
            lionpositions11.instance.undestructable = false;
            lionsnumber--;
        }
        if (collision.gameObject.tag == "lion12")
        {
            lionpositions12.instance.undestructable = false;
            lionsnumber--;
        }

        if (collision.gameObject.tag == "snake1")
        {
            snakepositions1.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake2")
        {
            snakepositions2.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake3")
        {
            snakepositions3.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake4")
        {
            snakepositions4.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake5")
        {
            snakepositions5.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake6")
        {
            snakepositions6.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake7")
        {
            snakepositions7.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake8")
        {
            snakepositions8.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake9")
        {
            snakepositions9.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake10")
        {
            snakepositions10.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake11")
        {
            snakepositions11.instance.undestructable = false;
            snakesnumber--;
        }
        if (collision.gameObject.tag == "snake12")
        {
            snakepositions12.instance.undestructable = false;
            snakesnumber--;
        }

    }
}
