using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

       public AudioClip jumpAudio;
        public AudioClip hurtAudio;
public AudioClip shootAudio1;
public AudioClip shootAudio2;
public AudioClip healthAudio3;
 public AudioSource audioSource;
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
    GameObject bulletPrefab,bulletPrefab2;
[SerializeField]
  GameObject gameOverScreeen;
[SerializeField]
    float start,end;

 public static long isLoop = 3000;

public  Camera cam;

  int isLoading = 2000;

	public static int bullet2 =3;

    private void Start()
    {
  audioSource = GetComponent<AudioSource>();
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

isLoading -=100;

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

	if(Input.GetKeyDown(KeyCode.LeftShift)&& PlayerMovement .bullet2 >0){
anim.SetBool("isThrowing", true);
}
    if (Input.GetKeyUp(KeyCode.Space))
        {
         Bullet(bulletPrefab);
PlaySound(shootAudio1);
              anim.SetBool("isThrowing", false);
            
        }


        if (Input.GetKeyUp(KeyCode.LeftShift) && PlayerMovement .bullet2 >0)
        {
 audioSource.PlayOneShot(shootAudio2);
PlayerMovement .bullet2 -=1;
     Bullet(bulletPrefab2);
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
  audioSource.PlayOneShot(jumpAudio);

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

void Bullet(GameObject bullet){
   GameObject obj = Instantiate(bullet, transform.position, Quaternion.identity);
             obj.transform.position += new Vector3(0.02f,0.3f,0);
            Bullet b = obj.GetComponent<Bullet>();
            b.direction = transform.localScale.x;
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

HealthPlayer(other,10);
        } else  if (other.tag == "HP_Bonus"){
PlaySound(healthAudio3);
       Destroy(other,1f);
}
	else if (other.tag == "Bullet2"){
PlayerMovement .bullet2 +=1;
       Destroy(other);
}

    }

    private void  OnTriggerStay2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;


            if (other.tag == "BatEnemyPlayer")
        {
PlaySound(hurtAudio);
if(isLoading<=0){
HealthPlayer(other,5);
isLoading = 2000;
}
        } 
}

 void HealthPlayer(GameObject other, float hel){

      
HealthBarScript. health -= hel;
			if(HealthBarScript. health <= 0){
            transform.position = startPosition;

cam. transform.position = cam.GetComponent<CustomCamera .FollowCamera2D>().startPosition;
HealthBarScript. lives -=1;
HealthBarScript. health =100;
if(HealthBarScript. lives <=0){
gameOverScreeen.SetActive (true);
PlayerMovement .isControll=false;
}
}
}


void PlaySound(AudioClip audio){
if (!audioSource.isPlaying)
        {
   audioSource.PlayOneShot(audio);
}
}
}