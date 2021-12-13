using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool gameispaused = false;

	public GameObject pauseMenuUI;
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Escape))
			
		{
	if (gameispaused)
				
	{
		Resume();

	} else 
	{
		Pause();
}
			//Screen.lockCursor = false;
			//Screen.lockCursor = true;
}

}
public void Resume()
{
	pauseMenuUI.SetActive(false);
	Time.timeScale = 1f;
	gameispaused = false;
	Screen.lockCursor = true;
}
void Pause ()

{
	pauseMenuUI.SetActive(true);
	Time.timeScale = 0f;
	gameispaused = true; 
	Screen.lockCursor = false;
	
}
	public void LoadMenu()
	{
		Time.timeScale = 1f; 
		SceneManager.LoadScene ("Menu");
	}
	public void QuitGame()
	{
		Debug.Log("Quitting game...");
		Application.Quit ();
	}
}
