using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGUI : MonoBehaviour
{
    public GUISkin guiSkin;

    void OnGUI() {
        GUI.skin = guiSkin;

        if (GUI.Button(new Rect(Screen.width / 2 - 120, Screen.height / 2 - 20, 250, 100), "Start")) {
            Application.LoadLevel("SampleScene");
        }

        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 200, 600, 100), "2D Space Shooter");
    }
}
