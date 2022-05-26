using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

[SerializeField]
       public AudioClip batAudio;


Image healthBar;
float maxHealth = 100f;
public static float health;
public static float healthEn;
 public  float healthBet = 100;


public static int lives = 3;

	void Start(){
		healthBar = GetComponent<Image>();
		health = maxHealth;
		healthEn = maxHealth; 
	}

	void Update(){
	if (healthBar.tag == "EnemyBar"){
		healthBar.fillAmount = healthEn / maxHealth;
}
	else if  (healthBar.tag == "PlayerBar"){
	healthBar.fillAmount = health / maxHealth;
	}
else if  (healthBar.tag == "BetBar")
	healthBar.fillAmount = healthBet / maxHealth;
	}



}