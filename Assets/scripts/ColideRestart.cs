using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColideRestart : MonoBehaviour
{
    public WordManager WordManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("word"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
            int save = WordManager.score;
            PlayerPrefs.SetInt("score", save);
        }
    }
}
