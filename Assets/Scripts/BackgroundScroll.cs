using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

    // Scroll main texture based on time
    public float scrollSpeed = 0.1f;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, Time.time * scrollSpeed));
    }
}
