using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

Image healthBar;
float maxHealth = 100f;
public static float health;
public static float healthEn;


	void Start(){
		healthBar = GetComponent<Image>();
		health = maxHealth;
		healthEn = maxHealth; 
	}

	void Update(){
	if (healthBar.tag == "EnemyBar"){
		healthBar.fillAmount = healthEn / maxHealth;
print("tttttt Update Update Programming"+HealthBarScript.healthEn);
}
	else if  (healthBar.tag == "PlayerBar")
	healthBar.fillAmount = health / maxHealth;
print(" tttttt Update Update Programming"+healthBar.tag);
	}



}