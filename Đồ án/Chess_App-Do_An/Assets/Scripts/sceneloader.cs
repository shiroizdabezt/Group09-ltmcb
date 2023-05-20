using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    public void Exit()
    {
        SceneManager.LoadScene("New Scene");
        Debug.Log("Exit");
    }    
}
