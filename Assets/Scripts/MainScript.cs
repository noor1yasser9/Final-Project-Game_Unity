using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
       [SerializeField]
    Button level2;
   [SerializeField]
    Button level3;
   [SerializeField]
    Button level4;
   [SerializeField]
    Button level5;
    void Start()
    {
        level2.enabled = PlayerPrefs. GetInt("level2",0)==1?true:false;
changeColor(level2,PlayerPrefs. GetInt("level2",0));
        level3.enabled = PlayerPrefs. GetInt("level2",0)==1?true:false;
changeColor(level3,PlayerPrefs. GetInt("level3",0));
        level4.enabled = PlayerPrefs. GetInt("level4",0)==1?true:false;
changeColor(level4,PlayerPrefs. GetInt("level4",0));
        level5.enabled = PlayerPrefs. GetInt("level5",0)==1?true:false;
changeColor(level5,PlayerPrefs. GetInt("level5",0));
    }

void changeColor(Button button, int isEnabled){
	if(isEnabled == 1){
   	button.GetComponent<Image>().color = Color.white;
   
}
}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void level(int i){
		Debug.Log("Play");
		SceneManager.LoadScene(i);
		PlayerPrefs. SetInt("level",i);	
HealthBarScript. healthEn = 100*i;
	}
	public void quitButton(){
		Debug.Log("Quit");
	}




}
