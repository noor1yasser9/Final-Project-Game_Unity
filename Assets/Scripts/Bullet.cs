using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    int lifeTime = 400;
    public float direction = 1;
    public float speed = 10;
    int dd = 0;
    // Update is called once per frame
    void Update()
    {
      
        transform.Translate(new Vector2(5 * direction, -2 * direction) * Time.deltaTime * speed);

        lifeTime -= 1;
        if(lifeTime < 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision){
   GameObject other = collision.gameObject;
        Debug.Log(other.tag);
        lifeTime -= 100;
    }

    public void OnTriggerEnter2D(Collider2D collision){
        GameObject other = collision.gameObject;
        if(other.tag == "TileMap") {
             Destroy(gameObject);
        }else if (other.tag == "BatEnemyPlayer"){
             Destroy(other);
            Destroy(gameObject);
        }else 	 if(collision.gameObject.CompareTag("BigEnemy")){
	HealthBarScript. healthEn -=2f;
             Destroy(gameObject);
		if(HealthBarScript. healthEn <=0){
//other.transform.Rotate(0,0,90);
EnemyDamage. isControl =false;
 		Destroy(other);
}
}
    }
    
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     GameObject other = collision.collider.gameObject;
    //     if(other.tag == "EnemyPlayer")
    //     {
    //         Destroy(other);
    //         Destroy(gameObject);
    //     }
    // }
}
