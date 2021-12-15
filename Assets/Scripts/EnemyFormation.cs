using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFormation : MonoBehaviour
{

    public bool movingDown;
    public bool movingSide;

    public Vector3 destination;
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        movingSide = true;
       
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
    }

    public void SetDestinationAndMoveDown()
    {
        destination = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        movingDown = true;
    }

    public void MoveDown()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime * speed);
    }

    public void MoveHorizontal()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
