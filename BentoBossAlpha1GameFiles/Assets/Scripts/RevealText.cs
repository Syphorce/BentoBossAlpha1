using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevealText : MonoBehaviour
{
    [SerializeField]
    private GameObject text;
    private bool isEnabled;


    private void Start()
    {
        
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        isEnabled = false;
        text.SetActive(isEnabled);
    }
    public void TurnOnAndOff()
    {
        isEnabled ^= true;
        text.SetActive(isEnabled);
    }
  
 }

