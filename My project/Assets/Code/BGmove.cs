using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmove : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed = 0.1F;
    public Renderer rend;
    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
    }


    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Repeat(Time.time * speed, 1);
        rend.material.mainTextureOffset = new Vector2(0, y);
    }

}
