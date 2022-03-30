using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SkinController : MonoBehaviour
{
    public void PlayGame()
    {
        int indexCharactor = int.Parse(EventSystem.current.currentSelectedGameObject.name);
        GameManager.instance.CharIndex = indexCharactor;

        SceneManager.LoadScene("Main");
    }


}//Class
