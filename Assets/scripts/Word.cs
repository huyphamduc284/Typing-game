using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Word
{

    public string word;
    private int typeIndex;

    public WordDisply wordDisply;

    public Word(string _word,WordDisply _wordDisply)
    {
        word = _word;
        typeIndex = 0;

        wordDisply = _wordDisply;
        wordDisply.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void typeLetter()
    {
        typeIndex++;
        wordDisply.removeLetter();
    }

    public bool Typed()
    {
        bool WordTyped = (typeIndex >= word.Length);

        if (WordTyped)
        {
            wordDisply.RemoveWord();
        }

        return WordTyped;
    }
}
