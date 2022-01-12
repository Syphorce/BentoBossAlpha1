using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevealText : MonoBehaviour
{
    public Text displayText;
   
    
    // Start is called before the first frame update
    void Start()
    {
        displayText.text = " ";
       
    }

    public void Displaytext()
    {
        displayText.text = "Left click Menu item to drop food. Left click to Drag and Drop food.  Use 'WASD' to rotate food. Hit Restart to empty bento box.";


    }



}
