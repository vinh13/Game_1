using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIController : MonoBehaviour
{
     public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
         

    public void GoHome()
    {
        SceneManager.LoadScene("Home");
    }
}
