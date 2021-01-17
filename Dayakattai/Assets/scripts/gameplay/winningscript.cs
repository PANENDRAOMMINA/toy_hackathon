using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winningscript : MonoBehaviour
{
    // Start is called before the first frame update
    public int vipers=0, lions=0;
    public static winningscript instance;
    public AudioClip player1win, player2win;
    [SerializeField] public int winningpoints;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }
    private void Update()
    {
        if(lions==winningpoints)
        {
            scoreboardmanager.instance.teamlions.SetActive(true);
            Time.timeScale = 0;
           
        }
        if (vipers == winningpoints)
        {
            scoreboardmanager.instance.teamvipers.SetActive(true);
            Time.timeScale = 0;
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "lion1" || collision.gameObject.tag == "lion2" || collision.gameObject.tag == "lion3" || collision.gameObject.tag == "lion4" || collision.gameObject.tag == "lion5" ||
            collision.gameObject.tag == "lion6"||collision.gameObject.tag=="lion7"||collision.gameObject.tag=="lion8"||collision.gameObject.tag=="lion9"||collision.gameObject.tag=="lion10"||
            collision.gameObject.tag=="lion11"||collision.gameObject.tag=="lion12")
        {
            Destroy(collision.gameObject);
            lions++;
        }
        if(collision.gameObject.tag=="snake1"||collision.gameObject.tag=="snake2"||collision.gameObject.tag=="snake3"||collision.gameObject.tag=="snake4"||collision.gameObject.tag=="snake5"||
            collision.gameObject.tag=="snake6"||collision.gameObject.tag=="snake7"||collision.gameObject.tag=="snake8"||collision.gameObject.tag=="snake9"||collision.gameObject.tag=="snake10"||
            collision.gameObject.tag == "lion11" || collision.gameObject.tag == "lion12")
        {
            Destroy(collision.gameObject);
            vipers++;
        }
    }
    
}
