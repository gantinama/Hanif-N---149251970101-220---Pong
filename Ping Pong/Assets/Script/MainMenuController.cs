using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created By Hanif Naufalianto-149251970101-220");
    }
    public void GetAuthor()
    {
        Debug.Log("Created By Hanif Naufalianto-149251970101-220");
    }
}
