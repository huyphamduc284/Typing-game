using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordObject;

    public Transform parent;

    public WordDisply spawner()
    {

        Vector2 position = new Vector2(Random.Range(-1.8f, 1.8f), 7);
        
        GameObject word = Instantiate(wordObject,position,Quaternion.identity,parent);
        WordDisply wordDisply = word.GetComponent<WordDisply>();

        return wordDisply;
    }
}
