using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RManager : MonoBehaviour {

	public Image hpBar;
	public Text scoreText;
	private int currentScore = 0;

	private static RManager instance;
	public static RManager Instance () {
		return instance;
	}

	void Awake (){
		if (instance != null){
			Destroy (gameObject);
		}
		else {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RefillHP (float amount){
		hpBar.fillAmount += amount;
	}

	public void AddScore (int amount){
		currentScore += amount;
		scoreText.text = currentScore.ToString();
	}
}