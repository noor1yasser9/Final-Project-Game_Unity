using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{



 public AudioSource audioSource;
       public AudioClip coinAudio;

    private void Start()
    {
  audioSource = GetComponent<AudioSource>();

} 
void OnTriggerEnter2D(Collider2D other)
{
    


if(other.gameObject.CompareTag("Player")){
if (!audioSource.isPlaying){
   audioSource.PlayOneShot(coinAudio);
}    
Destroy(gameObject,0.500f);
}

}




}
