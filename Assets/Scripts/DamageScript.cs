using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
	 if(col.gameObject.CompareTag("Player")){
	HealthBarScript. health -=10f;
}
}
private void OnTriggerStay2D(Collider2D other)
    {
if(other.gameObject.CompareTag("Player")){
       HealthBarScript. health -=2f;
    }
}
}
