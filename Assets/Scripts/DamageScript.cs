using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
[SerializeField] private float damage;
    void OnTriggerEnter2D(Collider2D col){
	 if(col.gameObject.CompareTag("Player")){
	HealthBarScript. health -= damage;
}
}
private void OnTriggerStay2D(Collider2D other)
    {
if(other.gameObject.CompareTag("Player")){
		if( HealthBarScript.health<=0){
			other.gameObject.GetComponent<PlayerMovement>().transform.position  = 	other.gameObject.GetComponent<PlayerMovement>().startPosition ;
 HealthBarScript. health = 100f;

}
       //HealthBarScript. health -=2f;
    }
}
}
