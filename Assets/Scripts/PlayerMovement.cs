using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


      public float MovementSpeed = 2;
    public float JumpForce = 4;
    private Rigidbody2D _rigidbody;
    private object body;
    private bool facingRightDirction;
    private object vector3;
    public Animator anim;
        Vector3 startPosition;
[SerializeField]
    GameObject bulletPrefab;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
        startPosition = transform.position;
print("ttttt"+ startPosition);
    }

    private void Update()
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


    }
    void Flip()
    {
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
     }

  
    private void  OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;


            if (other.tag == "BatEnemyPlayer")
        {
            transform.position = startPosition;

            return;
        }
    }


}