using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomBox : MonoBehaviour {

    public float delay = 10f;
    float countdown;
    bool hasBoom = false;
    public GameObject Explosion;

	void Start () {
        countdown = delay;
	}
	
	void Update () {
        countdown -= Time.deltaTime;
        if(countdown <= 0f && !hasBoom)
        {
            Explode();
            hasBoom = true;
        }
	}

    void Explode()
    {
        Debug.Log("BOOM!");
        Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
