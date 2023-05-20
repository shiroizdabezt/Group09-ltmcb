using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
{
    // Start is called before the first frame update
    public void Scoreboard_open()
    {
        SceneManager.LoadScene("Scoreboard");
    }
}
