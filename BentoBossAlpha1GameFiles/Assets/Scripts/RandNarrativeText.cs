using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandNarrativeText : MonoBehaviour
{

    public Text objectiveText;

    void Start ()
    { //On Game Start, this functiion will initiate
        PickRandomFromList();
    }

    public void PickRandomFromList() {
        //Narrative prompt list
        string[] narrativePrompt = new string[] { "Could I please have ", "Would you include ", "Maybe add ", "What about some ", "Can I try the " , "Can I have the " , "Where's the " };
        
        //Food list to suggest to the player
        string[] narrativeFood = new string[] { "boiled egg", "onigiri", "rice ball", "avocado maki", "salmon maki", "surimi maki", "kiwi", "lettuce", "squid tentacle", "fried egg",
        "cucumber nigiri", "salmon nigiri", "cherry tomato", "cucumber slice", "mushroom", "sausage", "radish slice" , "orange slice"};
        
        //Objective is the Prompt + Food + Punctuation
        string narrativeObjective = narrativePrompt[Random.Range(0, narrativePrompt.Length)] + narrativeFood[Random.Range(0, narrativePrompt.Length)] + "?";
        
        //Final output is the above Objective
        objectiveText.text = narrativeObjective;

    }

}
