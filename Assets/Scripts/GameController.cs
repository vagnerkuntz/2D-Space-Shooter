using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int lives = 3;
    public int score = 0;
    public GameObject player;
    public bool gameOver = false;
    public GUISkin guiSkin;
    private int level;
    public int totalEnimies = 0;
    public GameObject[] enemies;

    void Awake() {
        lives = 3;
        score = 0;
        gameOver = false;
        totalEnimies = 0;

        Instantiate(player, new Vector3(0f, 0f, -1.99f), transform.rotation);
    }

    void FixedUpdate()
    {
        if (totalEnimies == 0) {
            StartCoroutine(LevelEnd());
        }
    }

    public IEnumerator LevelEnd() {
        level += 1;

        if (level == 1) {
            totalEnimies = 4;

            yield return new WaitForSeconds(1);
            Instantiate(enemies[0], new Vector3(-4f, 0f, 2f), transform.rotation);
            yield return new WaitForSeconds(2);
            Instantiate(enemies[0], new Vector3(-2f, 0f, 2f), transform.rotation);
            yield return new WaitForSeconds(3);
            Instantiate(enemies[0], new Vector3(2f, 0f, 2f), transform.rotation);
            yield return new WaitForSeconds(4);
            Instantiate(enemies[0], new Vector3(4f, 0f, 2f), transform.rotation);
        }
    }

    public IEnumerator Respawn() {
        yield return new  WaitForSeconds(2);
        Instantiate(player, new Vector3(0f, 0f, -1.99f), transform.rotation);
    }

    void OnGUI() {
        GUI.skin = guiSkin;
        GUI.Label(new Rect(Screen.width / 2 - 370, 0, 400, 100), "Pontos: " + score.ToString());

        if (gameOver == true) {
            if (GUI.Button(new Rect(Screen.width / 2 - 140, 200, 300, 100), "RESTART")) {
                Application.LoadLevel("SampleScene");
            }
        }
    }
}
