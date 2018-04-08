﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public string mainMenu;
	public bool isPaused;
	public GameObject pausedMenuCanvas;

	public void Update ()
	{
		if (this.isPaused) {
			pausedMenuCanvas.SetActive (true);
			Time.timeScale = 0f;
		} else {
			pausedMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
		}
		
		if (Input.GetKeyDown (KeyCode.Escape)) {
			this.isPaused = !this.isPaused;
		}
	}
	public void Resume ()
	{
		this.isPaused = false;
	}
		
	public void QuitToMain ()
	{
		SceneManager.LoadScene (this.mainMenu);
	}
}