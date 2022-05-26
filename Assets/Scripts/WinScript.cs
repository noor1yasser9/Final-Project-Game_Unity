using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class WinScript : MonoBehaviour
{

 public AudioSource audioSource;
       public AudioClip audio;

[SerializeField]
  GameObject winScreen;
Animator anim;
int isLoad = 0;
 int sleep = 600*40;
    // Start is called before the first frame update


    void Start()
    {
        anim = GetComponent<Animator> ();
         anim.SetBool("isStart", false);
  audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
if(isLoad==1){
if(sleep<0){
winScreen.SetActive (true);

}
  sleep -= 100;
}
        
    }

    void OnTriggerEnter2D(Collider2D col){

			

//PlayerPrefs.DeleteAll();
	 if(col.gameObject.CompareTag("Player") && !EnemyDamage.isControl){
		 audioSource.PlayOneShot(audio);

	PlayerMovement.isControll = false;
anim.SetBool("isStart", true);	
isLoad = 1;
}
	}

  

}
