using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DamageScript : MonoBehaviour
{
[SerializeField] private float damage;

public  Camera cam;
[SerializeField]
  GameObject gameOverScreeen;
    private void Start()
    {



	cam = GameObject.Find("Main Camera").GetComponent<Camera>();
}


    void OnTriggerEnter2D(Collider2D col){
	 if(col.gameObject.CompareTag("Player")){
if(damage>0)
	HealthBarScript. health -= damage;
else{
if(HealthBarScript. health<100){
HealthBarScript. health -= damage;
}else {
HealthBarScript. lives +=1;
}
}
}
}

private void OnTriggerStay2D(Collider2D other)
    {
if(other.gameObject.CompareTag("Player")){
		if( HealthBarScript.health<=0){
			other.gameObject.GetComponent<PlayerMovement>().transform.position  = 	other.gameObject.GetComponent<PlayerMovement>().startPosition ;
 HealthBarScript. health = 100f;
cam. transform.position = cam.GetComponent<CustomCamera .FollowCamera2D>().startPosition;
HealthBarScript. lives -=1;
if(HealthBarScript. lives <=0)
gameOverScreeen.SetActive (true);
PlayerMovement .isControll=false;
}
       //HealthBarScript. health -=2f;
    }
}
}
