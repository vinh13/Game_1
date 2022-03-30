using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class HomeController : MonoBehaviour
{
    public GameObject skinPanel;
    private int _indexCharactor = 0;

    public void SplayScreen()
    {
        SceneManager.LoadScene("Main");
        
        GameManager.instance.CharIndex = _indexCharactor;
    }

    public void SkinScreen()
    {
        SceneManager.LoadScene("Skin");
    }

    public void SettingScreen()
    {
        SceneManager.LoadScene("Setting");
    }

    public void OpenSkinPanel()
    {
        skinPanel.SetActive(true);
    }

    public void CloseSkinPanel()
    {
        skinPanel.SetActive(false);
    }

    public int IndexCharactor
    {
        get { return _indexCharactor; }
        set { _indexCharactor = value; }
    }

}//Class
