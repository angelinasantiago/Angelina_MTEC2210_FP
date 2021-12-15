using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFormation : MonoBehaviour
{

    //Vector3 destination;
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        //destination = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //MoveDown();
        MoveHorizontal(1);
    }

    public void MoveDown(Vector3 destination)
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime * speed);
    }

    public void MoveHorizontal(int directionModifier)
    {
        transform.Translate(speed * Time.deltaTime * directionModifier, 0, 0);
    }
}
