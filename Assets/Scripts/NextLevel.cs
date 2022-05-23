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
HealthBarScript. healthEn = 100 * level;
}

	public void ReturnLevelFun(int level){
	PlayerPrefs.SetInt("level"+ level,1);

	PlayerMovement.isControll = true;
	EnemyDamage. isControl = true;
	SceneManager.LoadScene(level);
HealthBarScript. healthEn = 100 * level;
}

    public void HomeScreenFun(int level){
	PlayerPrefs.SetInt("level"+ level,1);

	PlayerMovement.isControll = true;
	EnemyDamage. isControl = true;
	SceneManager.LoadScene(0);
HealthBarScript. lives= 3;
HealthBarScript. healthEn = 100 * level;
}

public void GameOver(int level){
	PlayerMovement.isControll = true;
	EnemyDamage. isControl = true;
	SceneManager.LoadScene(level);
HealthBarScript. lives = 3;
HealthBarScript. healthEn = 100 * level;
}

public void HomeScreenGameOver(){
	PlayerMovement.isControll = true;
	EnemyDamage. isControl = true;
	SceneManager.LoadScene(0);
HealthBarScript. lives= 3;
HealthBarScript. healthEn = 0;
}


}
