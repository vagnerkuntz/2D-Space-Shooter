using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Movement : MonoBehaviour
{
    public Vector2 enemyWiggle;
    public float enemySpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * enemySpeed, enemyWiggle.x), transform.position.y, transform.position.z);
        //transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * enemySpeed, enemyWiggle.y));
    }
}
