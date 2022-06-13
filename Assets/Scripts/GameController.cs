using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int lives = 3;
    public GameObject player;

    public IEnumerator Respawn() {
        Instantiate(player, new Vector3(0f, 0f, -2.5f), transform.rotation);
        yield return new WaitForSeconds(1);
    }
}
