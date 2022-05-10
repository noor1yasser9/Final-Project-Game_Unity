using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void level(int i){
		Debug.Log("Play");
		SceneManager.LoadScene(i);
	}
	public void quitButton(){
		Debug.Log("Quit");
	}
}
