using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoltable : MonoBehaviour {

	public float hpRegain;
	public int scoreGain;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.CompareTag("Player"))
		{
			RManager.Instance().RefillHP(hpRegain);
			RManager.Instance().AddScore(scoreGain);
			gameObject.SetActive(false);
		}
	}
}