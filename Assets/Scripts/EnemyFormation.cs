using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFormation : MonoBehaviour
{

    Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        destination = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        MoveDown();
    }

    public void MoveDown()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime * 2);
    }
}