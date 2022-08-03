using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public PlayerState playerState;

    public void SelectLevel(int level) {
        playerState.level = level;
        playerState.Save();
        SceneManager.LoadScene(1);
    }
    public void BackToMenu() => SceneManager.LoadScene(2);






}
