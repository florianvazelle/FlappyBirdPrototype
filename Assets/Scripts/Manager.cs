using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {
    public GameObject DeathMenu;

    private void Start() {
        DeathMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver() {
        DeathMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart() {
        SceneManager.LoadScene("FlappyBirdPrototype");
    }
}
