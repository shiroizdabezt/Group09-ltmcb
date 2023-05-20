using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class New_game : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game"); // Thay "GameScene" bằng tên của scene bạn muốn chuyển đến
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
