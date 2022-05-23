using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public static bool isControll = true;

      public float MovementSpeed = 2;
    public float JumpForce = 4;
    private Rigidbody2D _rigidbody;
    private object body;
    private bool facingRightDirction;
    private object vector3;
    public Animator anim;
     public  Vector3 startPosition;
[SerializeField]
    GameObject bulletPrefab;

[SerializeField]
    float start,end;

 public static long isLoop = 3000;

public  Camera cam;

    private void Start()
    {

	cam = GameObject.Find("Main Camera").GetComponent<Camera>();

controlCamer();
        _rigidbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
        startPosition = transform.position;
print("ttttt"+ startPosition);
isLoop = 0;
    }

    private void Update()
    {

controlCamer();


if(isControll)
{
        var movement = Input.GetAxis("Horizontal");
 if (movement > 0 && transform.localScale.x < 0)
        {
            Flip();

        }
        else if (movement < 0 && transform.localScale.x > 0)
        {
            Flip();

        }
         if (Input.GetKeyDown(KeyCode.Space)){
 anim.SetBool("isThrowing", true);
         }
    if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject obj = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
             obj.transform.position += new Vector3(0.02f,0.3f,0);
            Bullet b = obj.GetComponent<Bullet>();
            b.direction = transform.localScale.x;
              anim.SetBool("isThrowing", false);
            
        }
        if (movement > 0 || movement < 0)
            anim.SetFloat("Speed", Mathf.Abs(movement));
        else
            anim.SetFloat("Speed", Mathf.Abs(-movement));


        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetKeyDown(KeyCode.UpArrow)  && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if (_rigidbody.velocity.y == 0)
        {
            anim.SetBool("isJumping", false);
        }
        if (_rigidbody.velocity.y > 0)
        {
            anim.SetBool("isJumping", true);
        }
        if (_rigidbody.velocity.y < 0)
        {
            anim.SetBool("isJumping", false);
        }

}else {
      anim.SetFloat("Speed",0f);
}
    }
    void Flip()
    {
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;


     }

	 void controlCamer(){
	if(transform.position.x < start){
CustomCamera .FollowCamera2D. isControl = false;
}else if(transform.position.x>= end){
CustomCamera .FollowCamera2D. isControl = false;
}else{
CustomCamera .FollowCamera2D. isControl = true;
}}
  
    private void  OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;


            if (other.tag == "BatEnemyPlayer")
        {
            transform.position = startPosition;

cam. transform.position = cam.GetComponent<CustomCamera .FollowCamera2D>().startPosition;
            return;
        } else 
	if (other.tag == "HP_Bonus"){
       Destroy(other);
}
    }


}