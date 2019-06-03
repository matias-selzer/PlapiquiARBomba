using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluirAgua : MonoBehaviour
{
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float offset = Time.time * speed * CaudalManager.caudal / 25.0f;;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0,offset);
    }
}
