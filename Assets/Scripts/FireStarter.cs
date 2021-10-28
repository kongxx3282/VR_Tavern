using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStarter : MonoBehaviour
{
    public ParticleSystem fire;

    // Start is called before the first frame update
    void Start()
    {
        fire.Pause();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider candle) 
    {
    	if (candle.gameObject.tag == "Candle")
    	{
            fire.Play();
    	}
    	
    }
}
