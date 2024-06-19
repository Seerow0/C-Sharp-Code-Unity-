using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//using UnityEngine.Audio;
public class FinalObstacleScore : MonoBehaviour {

    public float destroyDelay;
    public float sceneDelay;
    //public AudioClip SoundToPlay;

    //fixing FIXME_VAR_TYPE is always tricky solution as per how to script or object using and accessing it. Type Object and GameObject are good option for it, but not mostly, morethan 90% var type is float or vector3
    //FIXME_VAR_TYPE score= 0; 
    float score = 0;
	//GUIText guiScore; 
	bool  nextLevel;

	void  OnTriggerEnter ( Collider other  ){ 
		Debug.Log("OnTriggerEnter() was called"); 
		if (other.tag == "dog") 
		{ 
			score += 1; 
			AddScore ();
			//guiScore.text = "Score: " + score; 
			Debug.Log("Score is now " + score);
            

			//Destroy(other.gameObject);
			//yield WaitForSeconds(5).(audio.clip.length);
			//yield return new WaitForSeconds (5);
			//other is the gameobject


				

		} 
			
	} 
	void  AddScore (){ 
		score++; if( score == 2 )
        { Destroy(GameObject.Find("Giant"), destroyDelay);
          
            SceneManager.LoadSceneAsync("lis2");
            // Application.Quit();
            // print("quitbich"); 
        }
	}
}