using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

	public void NextLevelFun(int level){
PlayerPrefs.SetInt("level"+ level,1);

PlayerMovement.isControll = true;
EnemyDamage. isControl = true;
SceneManager.LoadScene(level);
}

	public void ReturnLevelFun(int level){
	PlayerPrefs.SetInt("level"+ level,1);

	PlayerMovement.isControll = true;
	EnemyDamage. isControl = true;
	SceneManager.LoadScene(level);
}

    public void HomeScreenFun(int level){
	PlayerPrefs.SetInt("level"+ level,1);

	PlayerMovement.isControll = true;
	EnemyDamage. isControl = true;
	SceneManager.LoadScene(0);
}

public void GameOver(int level){
	PlayerMovement.isControll = true;
	EnemyDamage. isControl = true;
	SceneManager.LoadScene(level);
}

public void HomeScreenGameOver(){
	PlayerMovement.isControll = true;
	EnemyDamage. isControl = true;
	SceneManager.LoadScene(0);
}


}
