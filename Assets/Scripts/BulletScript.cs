using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private GameManager gameManager;
    public float speed = 2;
    private float mod;
    public bool IsPlayerBullet;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        if (IsPlayerBullet)
        {
            mod = 1;
        } else
        {
            mod = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime * mod, 0);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {

            gameManager.increasescore(collision.gameObject.GetComponent<EnemyScript>().scorevalue);
            Destroy(collision.gameObject);
            
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            gameManager.restartgame();
        }

        Destroy(gameObject);
    }
}
