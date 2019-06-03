using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public int speedX, speedY, speedZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		int caudal = CaudalManager.caudal/25;
		transform.Rotate(new Vector3(speedX * Time.deltaTime*caudal, speedY * Time.deltaTime*caudal, speedZ * Time.deltaTime*caudal));
    }
}
