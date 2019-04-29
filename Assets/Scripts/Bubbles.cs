using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubbles : MonoBehaviour
{
    public GameObject bubblePrefab;
    public float timePerBubble;
    public float radius;
    private bool active;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("instantiateBubble", 0, timePerBubble);
    }

 
    public void instantiateBubble() {
        if (active) {
			Vector3 newPosition = (transform.localPosition);
            newPosition.z += Random.Range(-radius, radius);
            newPosition.y += Random.Range(-radius, radius);
            //newPosition.x += Random.Range(-radius, radius);
            GameObject burbuja = Instantiate(bubblePrefab) as GameObject;
			burbuja.transform.parent = gameObject.transform;
			burbuja.transform.localPosition = newPosition;
            float destroyTime = Random.Range(0.1f, 1.0f);
            float size = Random.Range(0.2f, 1.2f);
            burbuja.transform.localScale *= size;
            if (Random.Range(0, 3) == 2) {
                burbuja.GetComponent<AudioSource>().Play();
            }
            Destroy(burbuja, destroyTime);
        }
    }

    public void toggleActive() {
        active = !active;
        if (active) GetComponent<AudioSource>().volume = 1;
        else GetComponent<AudioSource>().volume = 0.2f;
    }

	public void activate(){
		active = true;
		GetComponent<AudioSource>().volume = 1;
		Debug.Log ("nico gazcon");
	}

	public void deactivate(){
		active = false;
		GetComponent<AudioSource>().volume = 0.2f;
	}
}
