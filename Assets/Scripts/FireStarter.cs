using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStarter : MonoBehaviour
{
    public ParticleSystem fire;
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        fire.Pause();
        light.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider candle) 
    {
    	if (candle.gameObject.tag == "Candle")
    	{
            fire.Play();
            light.SetActive(true);
    	}
    	
    }
}
