using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Managers : MonoBehaviour
{
    public Text score;

    private void Start()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
    }

    public void play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
