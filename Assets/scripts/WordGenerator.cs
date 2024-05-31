using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    public static string[] wordlist =
    {
        "Blue", "carousel", "moonlight", "whisper", "spectrum", "enigma", "quasar", "umbrella", "serendipity", "harmony", "jubilee",
"cascade", "silhouette", "effervescent", "nostalgia", "quixotic", "labyrinth", "ephemeral", "mystique", "ethereal", "velvet",
"paradox", "traverse", "mesmerize", "gossamer", "ebullient", "ineffable", "luminescent", "labyrinthine", "cascade", "oblivion",
"perennial", "evanescent", "serenity", "cynosure", "infinity", "eloquence", "obfuscate", "resplendent", "ephemeral", "tranquility",
"quintessence", "verdant", "iridescence", "ephemeral", "ineffable", "crepuscular", "evocative", "luminous", "paragon", "quasar",
"whimsical", "effulgent", "enigmatic", "languid", "mellifluous", "seraphic", "bucolic", "quintessential", "scintillating", "sumptuous",
"enchanting", "serendipity", "halcyon", "ethereal", "labyrinth", "luminous", "quiescent", "resplendent", "verdant", "mellifluous", "evocative",
"quintessential", "whimsical", "effervescent", "bucolic", "iridescent", "eloquence", "jubilant", "paragon", "seraphic", "obfuscate", "halcyon",
"oblivion", "luminescent", "quixotic", "crepuscular", "ineffable", "resplendent", "ephemeral", "quasar", "enigmatic", "spectrum", "evanescent",
"cynosure", "effulgent", "mesmerize", "labyrinthine", "verdant", "quintessence", "scintillating"
    };

    public static string GetRandomWord()
    {
        int index = Random.Range(0, wordlist.Length);
        string randomWord = wordlist[index];

        return randomWord;
    }
}
