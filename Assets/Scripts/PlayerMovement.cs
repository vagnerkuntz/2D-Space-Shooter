using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float movex = Input.GetAxisRaw("Horizontal") * Time.deltaTime * playerSpeed;
        float movez = Input.GetAxisRaw("Vertical") * Time.deltaTime * playerSpeed;

        transform.Translate(movex, 0, movez);

        // initially, the temporary vector should equal the player's position
        Vector3 clampedPosition = transform.position;
        
        // Now we can manipulte it to clamp the x element
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -3.8f, 3.8f);

        // re-assigning the transform's position will clamp it
        transform.position = clampedPosition;

        // Now we can manipulte it to clamp the x element
        clampedPosition.z = Mathf.Clamp(clampedPosition.z, 0.55f, 4.4f);

        // re-assigning the transform's position will clamp it
        transform.position = clampedPosition;
    }
}
