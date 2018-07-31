using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Countdown : MonoBehaviour {
    Image fillImg;
    float timeAmt = 5;
    float time;
	// Use this for initialization
	void Start ()
    {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(time > 0)
        {
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmt;
        }
	}
}
