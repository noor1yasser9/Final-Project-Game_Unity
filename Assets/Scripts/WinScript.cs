using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class WinScript : MonoBehaviour
{

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
//panel = GameObject.Find("Main Camera").GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
if(isLoad==1){
if(sleep<0){
/*if(PlayerPrefs.GetInt("level",1)!=5){
	SceneManager.LoadScene(PlayerPrefs. GetInt("level",1));
}else{
	SceneManager.LoadScene(0);
PlayerPrefs.SetInt("level",5);
}*/
winScreen.SetActive (true);

}
  sleep -= 100;
}
        
    }

    void OnTriggerEnter2D(Collider2D col){

			

//PlayerPrefs.DeleteAll();
	 if(col.gameObject.CompareTag("Player") && !EnemyDamage.isControl){
		
	PlayerMovement.isControll = false;
anim.SetBool("isStart", true);	
isLoad = 1;
		/*if(PlayerPrefs.GetInt("level",1)<=5){
Debug.Log("ttttlevel"+PlayerPrefs.GetInt("level",1));

		Debug.Log("ttttlevel"+PlayerPrefs.GetInt("level",1));
		 PlayerPrefs.SetInt("level"+PlayerPrefs.GetInt("level",1),1);
		PlayerPrefs.SetInt("level",PlayerPrefs.GetInt("level",1)+1);
 		
	 	
		
}	*/
}
	}

  

}
