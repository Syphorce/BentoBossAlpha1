using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandNarrativeText : MonoBehaviour
{

    public Text objectiveText;

    void Start ()
    {
        PickRandomFromList();
    }

    public void PickRandomFromList() {

        string[] narrativePrompt = new string[] { "Could I please have ", "Would you include ", "Maybe add ", "What about some ", "Can I try the " , "Can I have the " , "Where's the " };
        
        
        string[] narrativeFood = new string[] { "boiled egg", "onigiri", "rice ball", "avocado maki", "salmon maki", "surimi maki", "kiwi", "lettuce", "squid tentacle", "fried egg",
        "cucumber nigiri", "salmon nigiri", "cherry tomato", "cucumber slice", "mushroom", "sausage", "radish slice" , "orange slice"};
        
        string narrativeObjective = narrativePrompt[Random.Range(0, narrativePrompt.Length)] + narrativeFood[Random.Range(0, narrativePrompt.Length)] + "?";
        
        objectiveText.text = narrativeObjective;

    }

}
