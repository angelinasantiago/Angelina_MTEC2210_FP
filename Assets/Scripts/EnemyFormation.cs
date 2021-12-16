using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFormation : MonoBehaviour
{

    public bool movingDown;
    public bool movingSide;

    public Vector3 destination;
    public float speed = 2;

    private float decsendSpeed = 2;
    public GameObject bulletprefab;
    private float timeuntilfire;
    public float firedelay = 3;
    public AudioSource audiosource;
    public AudioClip deathclip;

    // Start is called before the first frame update
    void Start()
    {
        movingSide = true;
        timeuntilfire = firedelay;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (movingSide)
        {
            MoveHorizontal();
        }

        if (movingDown)
        {
            MoveDown();
        }

        if (timeuntilfire > 0)
        {
            timeuntilfire -= Time.deltaTime;
        } 
        else
        {
            enemyshoot();
            timeuntilfire = firedelay;
        }
    }

    public void playenemydeathaudio()
    {
        audiosource.PlayOneShot(deathclip);
    }

    public void enemyshoot()
    {
        int numberofenemies = GetComponentsInChildren<EnemyScript>().Length;
        int index = Random.Range(0, numberofenemies);
        var enemyarray = GetComponentsInChildren<EnemyScript>();
        Vector3 bullpos = enemyarray[index].transform.position;
        Instantiate(bulletprefab, bullpos, Quaternion.identity);
    }

    public void SetDestinationAndMoveDown()
    {
        destination = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        movingDown = true;
    }

    public void MoveDown()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime * decsendSpeed);
        
        if (transform.position == destination)
        {
            movingDown = false;
            speed *= -1;
            movingSide = true;
        }
    }

    public void MoveHorizontal()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
