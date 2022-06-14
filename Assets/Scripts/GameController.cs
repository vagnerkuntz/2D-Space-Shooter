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

    void Awake() {
        lives = 3;
        score = 0;
        gameOver = false;
    }

    public IEnumerator Respawn() {
        Instantiate(player, new Vector3(0f, 0f, -1.99f), transform.rotation);
        yield return new WaitForSeconds(1);
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
