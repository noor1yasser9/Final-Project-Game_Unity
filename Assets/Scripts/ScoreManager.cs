using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour

{



    public static ScoreManager instance;
    public Text text ; 
    public Text text2 ; 
    public Text text3 ; 
    int coinScore = 0 ; 
    int goldScore = 0 ; 
 


    // Start is called before the first frame update
    void Start()
    {

        if(instance == null){
            instance = this;
        }
        
    }
 
    void FixedUpdate()
    {
             text3.text = "Score  " + (coinScore + goldScore).ToString(); 

    }




public void ChangeCoinScore(int coinValue ){

    coinScore +=coinValue;
    text.text = coinScore.ToString();

}

public void ChangeGoldScore( int goldValue){

    goldScore +=goldValue;
    text2.text = goldScore.ToString();

}





 


 



}