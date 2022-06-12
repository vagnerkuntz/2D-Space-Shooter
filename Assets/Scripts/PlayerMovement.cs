using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float movex = Input.GetAxisRaw("Horizontal") * Time.deltaTime * playerSpeed;
        float movez = Input.GetAxisRaw("Vertical") * Time.deltaTime * playerSpeed;

        transform.Translate(movex, 0, movez);
        Vector3 clampedPosition = transform.position;

        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -3.8f, 3.8f);
        transform.position = clampedPosition;

        clampedPosition.z = Mathf.Clamp(clampedPosition.z, 0.55f, 4.4f);
        transform.position = clampedPosition;
    }
}
