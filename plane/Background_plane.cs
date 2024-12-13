using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_plane : MonoBehaviour
{
    public float moveSpeed = 1;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.mainTextureOffset += new Vector2(Time.deltaTime * moveSpeed * 0.02f, 0);
    }
}
