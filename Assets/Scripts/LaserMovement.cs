using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
// Scroll main texture based on time
    public float laserSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movez = laserSpeed * Time.deltaTime;
        transform.Translate(0, 0, movez);
        Vector3 position = transform.position;

        Debug.Log(position);

        if (position.z > 4.9) {
            Destroy(gameObject);
        }
    }
}
